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
    public partial class ListForm : Form
    {
        public string f1, f2, f3;
        private readonly CurrentStock _parent;
        

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
        
        public ListForm(CurrentStock parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void closeListbtn_Click(object sender, EventArgs e)
        {
            //close
            Close();
        }

        private void editListbtn_Click(object sender, EventArgs e)
        {
            //add to list
            if(quantityListtxt.Text == string.Empty || totalPriceListStktxt.Text == string.Empty)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }


            try
            {
                int check = Convert.ToInt32(quantityListtxt.Text);
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

            //set current date and time
            string d1 = DateTime.Now.Year.ToString();
            string d2 = DateTime.Now.Month.ToString();
            string d3 = DateTime.Now.Day.ToString();

            string d = d1 + " / " + d2 + " / " + d3;
            ListStock ls = new ListStock(itemIdListtxt.Text, ItemNameListtxt.Text, d, quantityListtxt.Text, unitPriceListtxt.Text, totalPriceListStktxt.Text);
            ListStockDB.AddListStock(ls);
            Close();
        }


        private void ListForm_Load(object sender, EventArgs e)
        {
            //buttons' borders curve
            editListbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, editListbtn.Width, editListbtn.Height, 15, 15));
            CalList.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, CalList.Width, CalList.Height, 15, 15));

            //give values in current tbl
            itemIdListtxt.Text = f1;
            ItemNameListtxt.Text = f2;
            unitPriceListtxt.Text = f3;
            itemIdListtxt.ReadOnly = true;
            ItemNameListtxt.ReadOnly = true;
            unitPriceListtxt.ReadOnly = true;
        }

        private void CalList_Click(object sender, EventArgs e)
        {
            //calculation of total in Listform
            int q = Convert.ToInt32(quantityListtxt.Text);
            int t1 = Convert.ToInt32(unitPriceListtxt.Text);

            totalPriceListStktxt.Text = Convert.ToString(q * t1);
        }

        
    }
}
