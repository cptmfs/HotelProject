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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void ServiceDelete(Testimionial entity)
        {
            _testimonialDal.Delete(entity); 
        }

        public List<Testimionial> ServiceGetAll()
        {
            return _testimonialDal.GetAll();
        }
        public Testimionial ServiceGetById(int id)
        {
            return _testimonialDal.GetById(id); 
        }

        public void ServiceInsert(Testimionial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void ServiceUpdate(Testimionial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
