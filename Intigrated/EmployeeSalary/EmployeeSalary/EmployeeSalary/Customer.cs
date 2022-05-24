using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class Customer
    {
        public string Arr_Year { get; set; }
        public string Arr_Month { get; set; }
        public string Arr_Time { get; set; }
        public string BID { get; set; }
        public string NIC { get; set; }
        public string Customer_Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact_No { get; set; }
        public string Vehicle_num { get; set; }
        


        public Customer( string arr_Year, string arr_Month, string arr_Time, string bID, string nIC, string customer_Name, string address, string email, string contact_No, string vehicle_num)
        {
     
            Arr_Year = arr_Year;
            Arr_Month = arr_Month;
            Arr_Time = arr_Time;
            BID = bID;
            NIC = nIC;
            Customer_Name = customer_Name;
            Address = address;
            Email = email;
            Contact_No = contact_No;
            Vehicle_num = vehicle_num;
         
            
        }
    }
}
