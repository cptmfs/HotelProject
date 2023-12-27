using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void ServiceDelete(Room entity)
        {
            _roomDal.Delete(entity);
        }

        public List<Room> ServiceGetAll()
        {
            return _roomDal.GetAll();
        }

        public Room ServiceGetById(int id)
        {
           return _roomDal.GetById(id);
        }

        public void ServiceInsert(Room entity)
        {
            _roomDal.Insert(entity);
        }

        public void ServiceUpdate(Room entity)
        {
            _roomDal.Update(entity);
        }
    }
}
