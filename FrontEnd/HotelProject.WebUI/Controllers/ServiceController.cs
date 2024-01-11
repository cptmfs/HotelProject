using HotelProject.Entity.Concrete;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Models.Staff;
using HotelProject.WebUI.Models.Testimonial;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ServiceController(IHttpClientFactory httpClientFactory, IWebHostEnvironment webHostEnvironment)
        {
            _httpClientFactory = httpClientFactory;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:25072/api/Service");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return View(value);

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]        
        public async Task<IActionResult> AddService(CreateServiceDto add)
        {
            if (!ModelState.IsValid) return View();
            var client = _httpClientFactory.CreateClient();


            if (add.ServiceIconUpload != null && add.ServiceIconUpload.Length > 0)
            {
                // Dosyayı kaydetme işlemi
                string fileName = GetUniqueFileName(add.ServiceIconUpload.FileName);
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Images", fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await add.ServiceIconUpload.CopyToAsync(fileStream);
                }

                // Service modelindeki ServiceIcon özelliğini dosya adıyla güncelleme
                add.ServiceIcon = fileName;
            }

            var jsonData = JsonConvert.SerializeObject(add);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:25072/api/Service", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View(add);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:25072/api/Service/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateServiceDto>(jsonData);

                return View(values);
            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceDto model)
        {
            if (!ModelState.IsValid) return View();

            var client = _httpClientFactory.CreateClient();

            if (model.ServiceIconUpload != null && model.ServiceIconUpload.Length > 0)
            {
                // Dosyayı kaydetme işlemi
                string fileName = GetUniqueFileName(model.ServiceIconUpload.FileName);
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Images", fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await model.ServiceIconUpload.CopyToAsync(fileStream);
                }

                // Service modelindeki ServiceIcon özelliğini dosya adıyla güncelleme
                model.ServiceIcon = fileName;
            }

            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:25072/api/Service", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
        public async Task<IActionResult> DeleteService(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.DeleteAsync($"http://localhost:25072/api/Service/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_"
                   + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
        }
    }
}
