using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            List<BookingApiLocationSearchViewModel> list = new List<BookingApiLocationSearchViewModel>();
            var client = new HttpClient();
           
            if (!string.IsNullOrEmpty(cityName))
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
                    Headers =
                {
                    { "X-RapidAPI-Key", "ca4edd0e38msh491633a601ce494p17d7d1jsn72cf9c36514e" },
                    { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
                    return View(list.Take(1));

                }
            }
            else
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Istanbul&locale=en-gb"),
                    Headers =
                {
                    { "X-RapidAPI-Key", "ca4edd0e38msh491633a601ce494p17d7d1jsn72cf9c36514e" },
                    { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
                    return View(list.Take(1));

                }
            }


        }
    }
}
