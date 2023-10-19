﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFTestimonialDal: GenericRepository<Testimonial>, ITestimonialDal
    {
        public EFTestimonialDal(Context context): base(context)
        {
            
        }
    }
}