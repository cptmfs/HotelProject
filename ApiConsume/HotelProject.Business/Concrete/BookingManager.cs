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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void ServiceDelete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public List<Booking> ServiceGetAll()
        {
            return _bookingDal.GetAll();
        }

        public Booking ServiceGetById(int id)
        {
            return _bookingDal.GetById  (id);
        }

        public void ServiceInsert(Booking entity)
        {
            _bookingDal.Insert(entity); 
        }

        public void ServiceUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }
    }
}
