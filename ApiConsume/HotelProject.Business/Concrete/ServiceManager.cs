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
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _servicesDal;

        public ServiceManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void ServiceDelete(Service entity)
        {
            _servicesDal.Delete(entity);
        }

        public List<Service> ServiceGetAll()
        {
            return _servicesDal.GetAll();
        }

        public Service ServiceGetById(int id)
        {
            return _servicesDal.GetById(id);
        }

        public void ServiceInsert(Service entity)
        {
            _servicesDal.Insert(entity);
        }

        public void ServiceUpdate(Service entity)
        {
            _servicesDal.Update(entity);
        }
    }
}
