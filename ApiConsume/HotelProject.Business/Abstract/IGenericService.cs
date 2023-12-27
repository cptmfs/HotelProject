using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void ServiceInsert(T entity);
        void ServiceUpdate(T entity);
        void ServiceDelete(T entity);
        List<T> ServiceGetAll();
        T ServiceGetById(int id);
    }
}
