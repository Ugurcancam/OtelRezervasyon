using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OtelRezervasyon.Business.Abstract;
using OtelRezervasyon.Data.Abstract;
using OtelRezervasyon.Entity.Concrete;

namespace OtelRezervasyon.Business.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void BDelete(Subscribe t)
        {
            _subscribeDal.Delete(t);
        }

        public Subscribe BGetById(int id)
        {
            return _subscribeDal.GetById(id); 
        }

        public List<Subscribe> BGetList()
        {
            return _subscribeDal.GetList(); 
        }

        public void BInsert(Subscribe t)
        {
            _subscribeDal.Insert(t);
        }

        public void BUpdate(Subscribe t)
        {
            _subscribeDal.Update(t);
        }
    }
}