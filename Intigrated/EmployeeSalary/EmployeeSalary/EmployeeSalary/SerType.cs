using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class SerType
    {
        public string SType { get; set; }
        public string Price { get; set; }

        public SerType(string sType, string price)
        {
            SType = sType;
            Price = price;
        }


    }
}
