using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class IncomeFinance
    {
        private IncomeTable incomeTable;

        public String CustomerID { get; set; }
        public String CustomerName { get; set; }
        public String VehicleID { get; set; }
        public String Time { get; set; }
        public String Day { get; set; }
        public String Month { get; set; }
        public String Year { get; set; }
        public String PaymenthM { get; set; }
        public String Price { get; set; }

        public IncomeFinance(string customerID, string customerName, string vehicleID, string time, string day, string month, string year, string paymenthM, string price)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            VehicleID = vehicleID;
            Time = time;
            Day = day;
            Month = month;
            Year = year;
            PaymenthM = paymenthM;
            Price = price;
        }
    }
}
