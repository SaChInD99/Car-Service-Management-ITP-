using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalary
{
    class booking
    {
        public string BID { get; set; }
        public string C_Name { get; set; }
        public string Contact_No { get; set; }
        public string Vehicle_No { get; set; }
        public string NIC { get; set; }
        public string B_Type { get; set; }
        public string Time { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Service_Slot { get; set; }

        public booking(string c_Name, string contact_No, string vehicle_No, string nIC, string b_Type, string time, string day, string month, string service_Slot)
        {
            
            C_Name = c_Name;
            Contact_No = contact_No;
            Vehicle_No = vehicle_No;
            NIC = nIC;
            B_Type = b_Type;
            Time = time;
            Day = day;
            Month = month;
            Service_Slot = service_Slot;
        }
    }
}
