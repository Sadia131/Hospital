using HospitalManagement1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement1.DataAccessLayer
{
    class StaffDataAccess
    {
        DataAccess dataAccess;
        public StaffDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Staff>GetAllStaffs()
        {
            string sql = "SELECT * FROM Staffs";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Staff> staffs = new List<Staff>();
            while (reader.Read())
            {
                Staff staff = new Staff();
                staff.StaffId = (int)reader["StaffId"];
                staff.StaffName = reader["StaffName"].ToString();
                staffs.Add(staff);
            }
            return staffs;
        }
        public Staff GetStaff(int id)
        {
            string sql = "SELECT * FROM  Staffs WHERE  StaffId-"+id;
            SqlDataReader reader =this.dataAccess.GetData(sql);
            reader.Read();
            Staff staff = new Staff();
            staff.StaffId = (int)reader["StaffId"];
            staff.StaffName = reader["StaffName"].ToString();
            return staff;
        }
        public int InsertStaff(Staff staff)
        {
            string sql = "INSERT INTO Staffs(StaffName) VALUES('"+staff.StaffName+"')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateStaff (Staff staff)
        {
            string sql = "UPDATE Staffs SET StaffName='"+staff.StaffName+"' WHERE StaffId="+staff.StaffId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int DeleteStaff(int id)
        {
            string sql = "DELETE FROM Staffs WHERE  StaffId="+id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public List<string> GetAllStaffNames()
        {
            string sql = "SELECT * FROM Staffs";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> staffs = new List<string>();
            while (reader.Read())
            {
                staffs.Add(reader["StaffName"].ToString());
            }
            return staffs;
        }

        public List<Employee> GetEmployeeListByStaff(string StaffName)
        {
            string StaffIdSearchSql = "SELECT * FROM Staffs WHERE StaffName = '" + StaffName + "'";
            SqlDataReader reader = this.dataAccess.GetData(StaffIdSearchSql);
            reader.Read();
            int StaffId = (int)reader["StaffId"];
            string sql = "SELECT * FROM Employees WHERE StaffId=" + StaffId;
            dataAccess = new DataAccess();
            reader = dataAccess.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Occupation = reader["Occupation"].ToString();
                employee.Specialist = reader["Specialist"].ToString();
                employee.Salary = (int) reader["Salary"];
                employee.StaffId = (int)reader["StaffId"];
                employees.Add(employee);
            }
            return employees;
        }
    }
}
