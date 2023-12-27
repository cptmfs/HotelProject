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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void ServiceDelete(Staff entity)
        {
            _staffDal.Delete(entity);
        }

        public List<Staff> ServiceGetAll()
        {
            return _staffDal.GetAll();
        }

        public Staff ServiceGetById(int id)
        {
            return _staffDal.GetById(id);
        }

        public void ServiceInsert(Staff entity)
        {
            _staffDal.Insert(entity);
        }

        public void ServiceUpdate(Staff entity)
        {
            _staffDal.Update(entity);
        }
    }
}
