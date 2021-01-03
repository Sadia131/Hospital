using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement1.DataAccessLayer
{
    class UserDataAccess
    {
        DataAccess dataAccess;
        public UserDataAccess()
        {
            this.dataAccess = new DataAccess(); 
        }
        public bool LogInValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='"+username+"' AND Password='"+password+"'";
                SqlDataReader reader = dataAccess.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
    }
}
