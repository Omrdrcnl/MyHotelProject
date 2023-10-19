using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {

        private readonly ISubscribeDal _subscribe;

        public SubscribeManager(ISubscribeDal subscribe)
        {
            _subscribe = subscribe;
        }

        public void TDelete(Subscribe entity)
        {
            _subscribe.Delete(entity);
        }

        public Subscribe TGetById(int id)
        {
            return _subscribe.GetById(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribe.GetList();
        }

        public void TInsert(Subscribe entity)
        {
            _subscribe.Insert(entity);
        }

        public void TUpdate(Subscribe entity)
        {
            _subscribe.Update(entity);
        }
    }
}
