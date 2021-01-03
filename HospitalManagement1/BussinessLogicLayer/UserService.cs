using HospitalManagement1.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement1.BussinessLogicLayer
{
    class UserService
    {
        UserDataAccess userDataAccess;
        public UserService()
        {
            userDataAccess = new UserDataAccess();

        }

        public bool LoginValidation(string username, string password)
        {
            return userDataAccess.LogInValidation(username, password);
        }
    }
}
