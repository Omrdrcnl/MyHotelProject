using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager:ITestimonialService
    {
        private readonly EFTestimonialDal _testimonial;

        public TestimonialManager(EFTestimonialDal testimonial)
        {
            _testimonial = testimonial;
        }

        public void TDelete(Testimonial entity)
        {
            _testimonial.Delete(entity);
        }

        public Testimonial TGetById(int id)
        {
           return _testimonial.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonial.GetList();
        }

        public void TInsert(Testimonial entity)
        {
            _testimonial.Insert(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonial.Update(entity);
        }
    }
}
