using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeSystem.Models
{
    public class EmployeeModel
    {

        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Father_Name { get; set; }
        public string Emp_Mother_Name { get; set; }
        public string Emp_BloodGroup { get; set; }
        public DateTime Emp_JoinDate { get; set; }
        public double Emp_Salary { get; set; }
        public string Emp_PresentAddress { get; set; }
        public DateTime Emp_DateOfBirth { get; set; }
        public string Emp_Marit_Status { get; set; }
        public string Emp_PhoneNumber { get; set; }        
    }
    public class EmployeeViewModel {
       public List<EmployeeModel> Empinfo = new List<EmployeeModel>();
    }
}