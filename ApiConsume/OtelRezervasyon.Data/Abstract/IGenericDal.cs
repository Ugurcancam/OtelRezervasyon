using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelRezervasyon.Data.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
    }
}