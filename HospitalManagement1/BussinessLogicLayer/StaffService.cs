using HospitalManagement1.DataAccessLayer;
using HospitalManagement1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement1.BussinessLogicLayer
{
    class StaffService
    {
        StaffDataAccess staffDataAccess;
        public StaffService()
        {
            this.staffDataAccess = new StaffDataAccess();
        }

      public List<Staff> GetStaffList()
        {
            return this.staffDataAccess.GetAllStaffs();
        }
        public int AddNewStaff(string staffName)
        {
            Staff staff = new Staff() { StaffName = staffName }; 
            return this.staffDataAccess.InsertStaff(staff);
        }

        public int UpdateStaff(int id,string staffName)
        {
            Staff staff = new Staff() { StaffId=id,StaffName = staffName };
            return this.staffDataAccess.UpdateStaff(staff);
        }

    }
}
