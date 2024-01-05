using AutoMapper;
using HotelProject.Business.Abstract;
using HotelProject.DTO.Dtos.RoomDto;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.ServiceGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(RoomAddDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(model);
            _roomService.ServiceInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(RoomUpdateDto model)
        {
            if (!ModelState.IsValid) 
                return BadRequest();

            var values=_mapper.Map<Room>(model);
            _roomService.ServiceUpdate(values);
            return Ok("Başarıyla Güncellendi.");
        }
    }
}
