using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.ServiceGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimionial testimonial)
        {
            _testimonialService.ServiceInsert(testimonial);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.ServiceGetById(id);
            _testimonialService.ServiceDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimionial testimonial)
        {
            _testimonialService.ServiceUpdate(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.ServiceGetById(id);
            return Ok(value);
        }
    }
}
