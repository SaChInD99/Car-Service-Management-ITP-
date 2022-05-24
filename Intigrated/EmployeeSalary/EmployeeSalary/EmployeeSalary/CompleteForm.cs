using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EmployeeSalary
{
    public partial class CompleteForm : Form
    {
        private readonly maincustomermanage _parent;
        //fix rectangle curves
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
        public string code;

       
        public CompleteForm(maincustomermanage parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        //Function for clearing the fields
        public void Clear()
        {
            txtService.Text = txtNIC.Text = txtcustomer.Text = txtVehicle.Text = txtComYear.Text = txtComMonth.Text = txtComTime.Text = txtServicecount.Text = txtDiscount.Text = txtRegards.Text = string.Empty;

        }

        private void CompleteForm_Load(object sender, EventArgs e)
        {
            //fix rectangle curves
            btnCancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCancel.Width, btnCancel.Height, 12, 12));
            btncSave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btncSave.Width, btncSave.Height, 12, 12));
            btnTimestamp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTimestamp.Width, btnTimestamp.Height, 12, 12));
            btncalcCount.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btncalcCount.Width, btncalcCount.Height, 12, 12));

        }

        //retrieving the values from the customer table to the form 
        public void addToCompleteTable(string f1, string f2, string f3, string f4,string f5,string f6)
        {
            txtService.Text = f1;
            txtNIC.Text = f2;
            txtcustomer.Text = f3;
            txtVehicle.Text = f4;
            txtarr_day.Text = f5;
            txtarr_month.Text = f6;


        }

        //the save button in the complete form
        private void btncSave_Click(object sender, EventArgs e)
        {
            if (txtService.Text.Trim().Length < 1)
            {
                MessageBox.Show("Service code is empty ( > 1)");
                return;
            }
            //trim is used to normalize all the spacing 
            if (txtNIC.Text.Trim().Length < 1)
            {
                MessageBox.Show("NIC is empty ( > 1)");
                return;
            }
            if (txtcustomer.Text.Trim().Length < 1)
            {
                MessageBox.Show("Customer Name is empty ( > 1)");
                return;
            }

            if (txtVehicle.Text.Trim().Length < 1)
            {
                MessageBox.Show("Vehicle number is empty( > 1)");
                return;
            }
            if (txtComYear.Text.Trim().Length < 1)
            {
                MessageBox.Show("Completion date is empty ( > 1)");
                return;
            }
            if (txtComMonth.Text.Trim().Length < 1)
            {
                MessageBox.Show("Completion month is empty ( > 1)");
                return;
            }
            if (txtComTime.Text.Trim().Length < 1)
            {
                MessageBox.Show("Completion time is empty ( > 1)");
                return;
            }
            if (txtServicecount.Text.Trim().Length < 1)
            {
                MessageBox.Show("Service count is empty");
                return;
            }
            if (txtDiscount.Text.Trim().Length < 1)
            {
                MessageBox.Show("Discount is Empty ( > 1)");
                return;
            }
            if (txtRegards.Text.Trim().Length < 1)
            {
                MessageBox.Show("Please add a regard on the service");
                return;
            }

            if (btncSave.Text == "Confirm Service")
            {
                Complete com = new Complete(txtService.Text.Trim(), txtNIC.Text.Trim(), txtcustomer.Text.Trim(), txtVehicle.Text.Trim(), txtComYear.Text.Trim(), txtComMonth.Text.Trim(), txtComTime.Text.Trim(), txtServicecount.Text.Trim(),txtDiscount.Text.Trim(), txtRegards.Text.Trim());
                DbCustomer.ConfirmCustomer(com);
                Clear();
            }
            _parent.Display();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
        //automatically take the date and time details
        private void btnTimestamp_Click(object sender, EventArgs e)
        {
            string monthNo = DateTime.Now.Month.ToString();
            String monthName = "";
            //convert the text into number
            int monthN = Convert.ToInt32(monthNo);

            if (monthN == 1)
                monthName = "January";
            else if (monthN == 2)
                monthName = "February";
            else if (monthN == 3)
                monthName = "March";
            else if (monthN == 4)
                monthName = "April";
            else if (monthN == 5)
                monthName = "May";
            else if (monthN == 6)
                monthName = "June";
            else if (monthN == 7)
                monthName = "July";
            else if (monthN == 8)
                monthName = "August";
            else if (monthN == 9)
                monthName = "September";
            else if (monthN == 10)
                monthName = "October";
            else if (monthN == 11)
                monthName = "November";
            else if (monthN == 12)
                monthName = "December";
            else
                monthName = "Not found";

            txtComYear.Text = DateTime.Now.Year.ToString();
            txtComMonth.Text = monthName;
            txtComTime.Text = DateTime.Now.Day.ToString() + " | " + DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString();
            
        }

        private void btncalcCount_Click(object sender, EventArgs e)
        {
            //getting the service count:how many times the same vehicle number repeats within a year
            int c = DbCustomer.getCount(txtarr_day.Text, txtVehicle.Text);
            //converting to string and assigning it into the text box
            txtServicecount.Text = Convert.ToString(c);
            
            //displaying the discount
            if (c == 3)
                txtDiscount.Text = "Yes";
            else
                txtDiscount.Text = "No";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //hover for the button timestamp
        private void btnTimestamp_MouseEnter(object sender, EventArgs e)
        {
            btnTimestamp.BackColor = Color.CadetBlue;
        }

        private void btnTimestamp_MouseLeave(object sender, EventArgs e)
        {
            btnTimestamp.BackColor = Color.Teal;
        }
        //hover for the button calculate
        private void btncalcCount_MouseEnter(object sender, EventArgs e)
        {
            btncalcCount.BackColor = Color.CadetBlue;
        }

        private void btncalcCount_MouseLeave(object sender, EventArgs e)
        {
            btncalcCount.BackColor = Color.Teal;
        }

        private void btncSave_MouseEnter(object sender, EventArgs e)
        {
            btncSave.BackColor = Color.ForestGreen;
        }

        private void btncSave_MouseLeave(object sender, EventArgs e)
        {
            btncSave.BackColor = Color.SeaGreen;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.DarkRed;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Firebrick;
        }
    }
}
