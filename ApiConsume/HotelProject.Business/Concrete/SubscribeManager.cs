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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void ServiceDelete(Subscribe entity)
        {
            _subscribeDal.Delete(entity);
        }

        public List<Subscribe> ServiceGetAll()
        {
            return _subscribeDal.GetAll();
        }

        public Subscribe ServiceGetById(int id)
        {
            return _subscribeDal.GetById(id);
        }

        public void ServiceInsert(Subscribe entity)
        {
            _subscribeDal.Insert(entity);
        }

        public void ServiceUpdate(Subscribe entity)
        {
            _subscribeDal.Update(entity);
        }
    }
}
