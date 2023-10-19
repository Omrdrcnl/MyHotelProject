﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFServiceDal: GenericRepository<Service> ,IServicesDal
    {
        public EFServiceDal(Context context): base(context)
        {
            
        }
    }
}
