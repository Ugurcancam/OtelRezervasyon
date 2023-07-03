using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OtelRezervasyon.Business.Abstract;
using OtelRezervasyon.Data.Abstract;
using OtelRezervasyon.Entity.Concrete;

namespace OtelRezervasyon.Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void BDelete(Service t)
        {
           _serviceDal.Delete(t);
        }

        public Service BGetById(int id)
        {
           return _serviceDal.GetById(id);
        }

        public List<Service> BGetList()
        {
           return _serviceDal.GetList();
        }

        public void BInsert(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void BUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}