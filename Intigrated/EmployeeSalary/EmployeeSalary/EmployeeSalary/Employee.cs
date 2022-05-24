using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeID { get; set; }
        public string NIC { get; set; }
        public string DOB { get; set; }
        public string Adress { get; set; }
        public string EmployeeEmail { get; set; }
        public string ContactNumber { get; set; }
        public string Attendence { get; set; }
        public string OT { get; set; }

        public Employee(string employeeName, string employeeID, string nIC, string dOB, string adress, string employeeEmail, string contactNumber, string attendence, string oT)
        {
            EmployeeName = employeeName;
            EmployeeID = employeeID;
            NIC = nIC;
            DOB = dOB;
            Adress = adress;
            EmployeeEmail = employeeEmail;
            ContactNumber = contactNumber;
            Attendence = attendence;
            OT = oT;
        }
    }
}
