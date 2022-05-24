using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class CurrentStockDB
    {
      //temporary saved 
        public string Item_Name { get; set; }
        public string Date { get; set; }
        public string Quantity { get; set; }
        public string Unit_Price { get; set; }
        public string Min_quantity { get; set; }

        public CurrentStockDB( string item_Name, string date, string quantity, string unit_Price, string min_quantity)
        {
           
            Item_Name = item_Name;
            Date = date;
            Quantity = quantity;
            Unit_Price = unit_Price;
            Min_quantity = min_quantity;
        }
    }
}
