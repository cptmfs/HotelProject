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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void ServiceDelete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public List<About> ServiceGetAll()
        {
            return _aboutDal.GetAll();
        }

        public About ServiceGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void ServiceInsert(About entity)
        {
            _aboutDal.Insert(entity);
        }

        public void ServiceUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
