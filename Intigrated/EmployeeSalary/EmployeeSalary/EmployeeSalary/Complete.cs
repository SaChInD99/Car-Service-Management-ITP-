using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class Complete
    {
 

        public string S_Code { get; set; }
        public string NIC { get; set; }
        public string Customer_Name { get; set; }
        public string Vehicle_num { get; set; }
        public string Com_Year { get; set; }
        public string Com_Month { get; set; }
        public string Com_Time { get; set; }
        public string Service_count { get; set; }
        public string Discount { get; set; }
        public string Service_Regards { get; set; }

        public Complete(string code, string nIC, string customer_Name, string vehicle_num, string com_Year, string com_Month, string com_Time, string service_count, string discount, string service_Regards)
        {
            S_Code = code;
            NIC = nIC;
            Customer_Name = customer_Name;
            Vehicle_num = vehicle_num;
            Com_Year = com_Year;
            Com_Month = com_Month;
            Com_Time = com_Time;
            Service_count = service_count;
            Discount = discount;
            Service_Regards = service_Regards;
        }
    }


}
