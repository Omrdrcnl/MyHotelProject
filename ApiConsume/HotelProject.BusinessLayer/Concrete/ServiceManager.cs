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
    public class ServiceManager: IServiceService
    {
        private readonly IServicesDal _services;

        public ServiceManager(IServicesDal services)
        {
            _services = services;
        }

        public void TInsert(Service entity)
        {
            _services.Insert(entity);
        }

        public void TDelete(Service entity)
        {
            _services.Delete(entity);
        }

        public void TUpdate(Service entity)
        {
            _services.Update(entity);
        }

        public List<Service> TGetList()
        {
            return _services.GetList();
        }

        public Service TGetById(int id)
        {
            return _services.GetById(id);
        }

    }
}
