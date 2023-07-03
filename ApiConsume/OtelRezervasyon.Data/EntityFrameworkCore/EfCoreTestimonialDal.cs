using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OtelRezervasyon.Data.Abstract;
using OtelRezervasyon.Data.Concrete;
using OtelRezervasyon.Data.Repositories;
using OtelRezervasyon.Entity.Concrete;

namespace OtelRezervasyon.Data.EntityFrameworkCore
{
    public class EfCoreTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EfCoreTestimonialDal(Context context) : base(context)
        {
        }
    }
}