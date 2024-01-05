using AutoMapper;
using HotelProject.DTO.Dtos.RoomDto;
using HotelProject.Entity.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>().ReverseMap();
            CreateMap<RoomUpdateDto, Room>().ReverseMap();
        }
    }
}
