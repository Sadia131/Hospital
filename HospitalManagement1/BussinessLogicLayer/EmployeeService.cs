using HospitalManagement1.DataAccessLayer;
using HospitalManagement1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement1.BussinessLogicLayer
{
    class EmployeeService
    {
        EmployeeDataAccess employeeDataAccess;
        public EmployeeService()
        {
            this.employeeDataAccess = new EmployeeDataAccess();
        }
        public List<Employee> GetEmployeesList()
        {
            return this.employeeDataAccess.GetAllEmployees();

        }
        public int AddNewEmployee(string employeeName, string occupation, string specialist, string salary, string staffName)
        {
            int staffId = this.employeeDataAccess.GetStaffId(staffName);
            Employee employee = new Employee()
            {
                EmployeeName = employeeName,
                Occupation = occupation,
                Specialist = specialist,
                Salary = Convert.ToInt32(salary),
                StaffId = staffId

            };
            employeeDataAccess = new EmployeeDataAccess();
            return this.employeeDataAccess.AddNewEmployee(employee);
        }

        public int DeleteEmployee(int id)
        {
            return this.employeeDataAccess.DeleteEmployee(id);
        }

        public int UpdateEmployee(int id, string employeeName)
        {
            Employee employee = new Employee()
            {
                EmployeeId = id,
                EmployeeName = employeeName
            };
            return this.employeeDataAccess.UpdateEmployee(employee);
        }


        public List<Employee> GetEmployeesListForSearch(string employeeName)
        {
            return this.employeeDataAccess.GetEmployeesByEmployeeName(employeeName);

        }


    }
}
