﻿using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.Repositories;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServicesDal
    {
        public EfServiceDal(Context context) : base(context)
        {
        }
    }
}
