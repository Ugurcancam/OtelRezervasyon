using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OtelRezervasyon.Business.Abstract;
using OtelRezervasyon.Data.Abstract;
using OtelRezervasyon.Entity.Concrete;

namespace OtelRezervasyon.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void BDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About BGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> BGetList()
        {
            return _aboutDal.GetList();
        }

        public void BInsert(About t)
        {
            _aboutDal.Insert(t);
        }

        public void BUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}