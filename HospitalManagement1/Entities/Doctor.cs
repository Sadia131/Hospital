using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement1.Entities
{
    class Doctor
    {
        public  int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int DoctorSpecialities { get; set; }
        public int StaffId { get; set; }
    }
}
