using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class StockCost
    {
        public string StockCostId { get; set; }
        public string Order_Id { get; set; }
        public string Item_Id { get; set; }
        public string Item_Name { get; set; }
        public string Date { get; set; }
        public string Req_Quantity { get; set; }
        public string Unit_Price { get; set; }
        public string Total_Price { get; set; }
        public object StockCostID { get; set; }

        public StockCost(string stockCostId, string order_Id, string item_Id, string item_Name, string date, string req_Quantity, string unit_Price, string total_Price)
        {
            StockCostId = stockCostId;
            Order_Id = order_Id;
            Item_Id = item_Id;
            Item_Name = item_Name;
            Date = date;
            Req_Quantity = req_Quantity;
            Unit_Price = unit_Price;
            Total_Price = total_Price;
        }
    }
}
