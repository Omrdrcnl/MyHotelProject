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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staff;

        public StaffManager(IStaffDal staff)
        {
            _staff = staff;
        }

        public void TDelete(Staff entity)
        {
            _staff.Delete(entity);
        }

        public Staff TGetById(int id)
        {
            return _staff.GetById(id);
        }

        public List<Staff> TGetList()
        {
            return _staff.GetList();
        }

        public void TInsert(Staff entity)
        {
            _staff.Insert(entity);
        }

        public void TUpdate(Staff entity)
        {
            _staff.Update(entity);
        }
    }
}
