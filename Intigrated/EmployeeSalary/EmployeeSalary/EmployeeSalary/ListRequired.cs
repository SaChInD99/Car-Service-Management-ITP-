using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class ListRequired : Form
    {
        public ListRequired()
        {
            InitializeComponent();
        }

        public void Display()
        {
            //display details in grid
            StockDB.DisplayAndSearch("SELECT Order_Id,Item_Id,Item_Name, Date, Req_Quantity, Unit_Price, Total_Price FROM liststock_table", tblRequiredgrid);
        }


        private void closeRequiredbtn_Click(object sender, EventArgs e)
        {
            //close
            CurrentStock f1 = new CurrentStock();
            f1.Show();
        }

        private void ListRequired_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void tblRequiredgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                //get values frm add to list buttn
                string id = tblRequiredgrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                ListStockDB.DeleteListStock(id);
                Display();
            }
        }

        private void searchRequiredtxt_TextChanged(object sender, EventArgs e)
        {
            //Search by item name
            ListStockDB.DisplayAndSearch("SELECT Order_Id ,Item_Id,Item_Name, Date, Req_Quantity, Unit_Price, Total_Price FROM liststock_table WHERE Item_Name LIKE '%" + searchRequiredtxt.Text + "%'", tblRequiredgrid);
        }

        private void searchRequiredtxt_Enter(object sender, EventArgs e)
        {
            //Search by item name(placeholder)
            if(searchRequiredtxt.Text == "Search By Item Name")
            {
                searchRequiredtxt.Text = "";
                searchRequiredtxt.ForeColor = Color.Black;
            }
        }

        
    }
}
