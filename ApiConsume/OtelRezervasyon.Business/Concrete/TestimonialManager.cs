using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OtelRezervasyon.Business.Abstract;
using OtelRezervasyon.Data.Abstract;
using OtelRezervasyon.Entity.Concrete;

namespace OtelRezervasyon.Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void BDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonial BGetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public List<Testimonial> BGetList()
        {
            return _testimonialDal.GetList();
        }

        public void BInsert(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void BUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}