using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class AddStock : Form
    {
        //fix rectangle to curve
       [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
             (
                 int nLeft,
                 int nTop,
                 int nRight,
                 int nBottom,
                 int nwidthEllipse,
                 int nHightEllipse
             );
       

        private readonly CurrentStock _parent;
        public string id,name,date,quantity,unit_price,total_price;


        public AddStock(CurrentStock parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        

        public void UpdateInfo()
        {
            //send add details' rslts to edit details
            AddDetailsAddStklbl.Text = "Edit Details";
            SaveAddStkbtn.Text = "Edit";
            //itemIdAddStktxt.Text = id;
            ItemNameAddStktxt.Text = name;
            dateTimePickerAddAtklbl.Text = date;
            quantityAddStktxt.Text = quantity;
            unitPriceAddStktxt.Text = unit_price;
            totalPriceAddStktxt.Text = total_price;

        }

        public void Clear()
        {
            //to clear all fields after add previous inputs
            ItemNameAddStktxt.Text = quantityAddStktxt.Text = unitPriceAddStktxt.Text = totalPriceAddStktxt.Text = string.Empty;
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            //btn corners rounded
            //itemIdAddStktxt.ReadOnly = true;//set id to unchanged
            SaveAddStkbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SaveAddStkbtn.Width, SaveAddStkbtn.Height, 15, 15));
            //calTotListbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, calTotListbtn.Width, calTotListbtn.Height, 15, 15));

        }


        private void closeAddStkbtn_Click(object sender, EventArgs e)
        {
            //close
            Close();
        }

         private void SaveAddStkbtn_Click(object sender, EventArgs e)
         {
              //txt box of item name
             if(ItemNameAddStktxt.Text.Trim().Length == 0)
             {
                 MessageBox.Show("Item Name is empty");
                 return;
             }

             //txt box of quantity
             if (quantityAddStktxt.Text.Trim().Length == 0)
             {
                 MessageBox.Show("Quantity is empty");
                 return;
             }

            try
            {
                int check = Convert.ToInt32(quantityAddStktxt.Text);
                if (check <= 0)
                {
                    MessageBox.Show("Invalid input");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Do not enter letters or any other symbols to this field!");
                return;
            }

             //txt box of unit price
             if (unitPriceAddStktxt.Text.Trim().Length == 0)
             {
                 MessageBox.Show("Unit price is empty");
                 return;
             }

            try
            {
                int check = Convert.ToInt32(unitPriceAddStktxt.Text);
                if (check <= 0)
                {
                    MessageBox.Show("Invalid input");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Do not enter letters or any other symbols to this field!");
                return;
            }

            //txt box of Min_quantity
            if (totalPriceAddStktxt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Minimum quantity is empty");
                return;
            }

            try
            {
                int check = Convert.ToInt32(totalPriceAddStktxt.Text);
                if (check <= 0)
                {
                    MessageBox.Show("Invalid input");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Do not enter letters or any other symbols to this field!");
                return;
            }

            if (SaveAddStkbtn.Text == "Save")//save btn when adding
             {
                //set current date & time in field in add stock
                string a1 = DateTime.Now.Year.ToString();
                string a2 = DateTime.Now.Month.ToString();
                string a3 = DateTime.Now.Day.ToString();

                string date = a1 + " / " + a2 + " / " + a3;
                CurrentStockDB std = new CurrentStockDB(ItemNameAddStktxt.Text.Trim(),date, quantityAddStktxt.Text.Trim(), unitPriceAddStktxt.Text.Trim(), totalPriceAddStktxt.Text.Trim());
                StockDB.AddCurrentStockDB( std);
                

                Clear();
             }

            if(SaveAddStkbtn.Text == "Edit")//edit btn when editing
            {
                //set currnt date and time in field
                string a1 = DateTime.Now.Year.ToString();
                string a2 = DateTime.Now.Month.ToString();
                string a3 = DateTime.Now.Day.ToString();

                string date = a1 + " / " + a2 + " / " + a3;
                CurrentStockDB std = new CurrentStockDB(ItemNameAddStktxt.Text.Trim(), date, quantityAddStktxt.Text.Trim(), unitPriceAddStktxt.Text.Trim(), totalPriceAddStktxt.Text.Trim());
                StockDB.UpdateCurrentStockDB(std,id);


                Clear();
            }

            _parent.Display();

         
    }
}
}
