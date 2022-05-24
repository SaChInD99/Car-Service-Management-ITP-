using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class EmployeeSalary
    {
        public string EmployeeSalaryID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeEmail { get; set; }
        public string OT { get; set; }
        public string ContactNumber { get; set; }
        public string Basic { get; set; }
        public string Attendence { get; set; }
        public string CalculatedSalary { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }

        public EmployeeSalary(string employeeSalaryID, string employeeName, string employeeID, string employeeEmail, string oT, string contactNumber, string basic, string attendence, string calculatedSalary, string month, string year)
        {
            EmployeeSalaryID = employeeSalaryID;
            EmployeeName = employeeName;
            EmployeeID = employeeID;
            EmployeeEmail = employeeEmail;
            OT = oT;
            ContactNumber = contactNumber;
            Basic = basic;
            Attendence = attendence;
            CalculatedSalary = calculatedSalary;
            Month = month;
            Year = year;
        }
    }
}
