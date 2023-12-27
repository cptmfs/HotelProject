using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }
        [HttpGet]
        public IActionResult SubscribeSList()
        {
            var values = _subscribeService.ServiceGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSubscribeS(Subscribe subscribe)
        {
            _subscribeService.ServiceInsert(subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribeS(int id)
        {
            var value = _subscribeService.ServiceGetById(id);
            _subscribeService.ServiceDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribeS(Subscribe subscribe)
        {
            _subscribeService.ServiceUpdate(subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribeS(int id)
        {
            var value = _subscribeService.ServiceGetById(id);
            return Ok(value);
        }
    }
}
