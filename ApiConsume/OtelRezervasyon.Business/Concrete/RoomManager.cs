using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OtelRezervasyon.Business.Abstract;
using OtelRezervasyon.Data.Abstract;
using OtelRezervasyon.Entity.Concrete;

namespace OtelRezervasyon.Business.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void BDelete(Room t)
        {
            _roomDal.Delete(t);
        }

        public Room BGetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public List<Room> BGetList()
        {
            return _roomDal.GetList();
        }

        public void BInsert(Room t)
        {
            _roomDal.Insert(t);
        }

        public void BUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}