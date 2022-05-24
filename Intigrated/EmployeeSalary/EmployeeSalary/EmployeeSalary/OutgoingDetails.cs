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
    public partial class OutgoingDetails : Form
    {
        FormEmployeeS form;

        public OutgoingDetails()
        {
            InitializeComponent();
        }


        public void Display()
        {
            DbEmployeeS.DisplayAndSearch("SELECT id,Year,Month,EmployeeSalaryID,OT,Basic,CalculatedSalary FROM employees", dataGridView1);
        }
        public void Display2()
        {
            DbEmployeeS.DisplayAndSearch("SELECT Order_Id,Date,Unit_Price,Total_Price FROM liststock_table", dataGridView2);
        }
        private void OutgoingDetails_Shown_1(object sender, EventArgs e)
        {
            Display();
            Display2();
        }


        public void loadOutgoingSalDetails(String m, String y)
        {
            /*String monthNo = DateTime.Now.Month.ToString();
            String monthName = "";
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
                monthName = "Octorber";
            else if (monthN == 11)
                monthName = "November";
            else if (monthN == 12)
                monthName = "December";
            else
                monthName = "Not found";*/

            int i = DbEmployeeS.getThisMonthTotalOutgoing( m, y);
            outgoingtxtx.Text = "Rs. " + Convert.ToString(i);
        }

  
        public void getThisMonthTotalStockOutgoing()
        {
            String monthNo = DateTime.Now.Month.ToString();
            String monthName = "";
            int monthN = Convert.ToInt32(monthNo);

            if (monthN == 1)
                monthName = "1";
            else if (monthN == 2)
                monthName = "2";
            else if (monthN == 3)
                monthName = "3";
            else if (monthN == 4)
                monthName = "4";
            else if (monthN == 5)
                monthName = "5";
            else if (monthN == 6)
                monthName = "6";
            else if (monthN == 7)
                monthName = "7";
            else if (monthN == 8)
                monthName = "8";
            else if (monthN == 9)
                monthName = "9";
            else if (monthN == 10)
                monthName = "10";
            else if (monthN == 11)
                monthName = "11";
            else if (monthN == 12)
                monthName = "12";
            else
                monthName = "Not found";

            //int i = ListStockDB.getThisMonthTotalStockOutgoing(monthName, Convert.ToString(DateTime.Now.Year));
            //textBox2.Text = "Rs. " + Convert.ToString(i);
        }

        private void OutgoingDetails_Load(object sender, EventArgs e)
        {

            timer1.Start();
            label7.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToLongDateString();

            String monthNo = DateTime.Now.Month.ToString();
            String monthName = "";
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
                monthName = "Octorber";
            else if (monthN == 11)
                monthName = "November";
            else if (monthN == 12)
                monthName = "December";
            else
                monthName = "Not found";

            loadOutgoingSalDetails(monthName, DateTime.Now.Year.ToString());
            getStockTotalOutgoing(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainDash = new MainDash();
            MainDash.Closed += (s, args) => this.Close();
            MainDash.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormEmployeeOutgoing = new FormEmployeeOutgoing();
            FormEmployeeOutgoing.Closed += (s, args) => this.Close();
            FormEmployeeOutgoing.Show();
        }

        public void getStockTotalOutgoing(String month,String year)
        {
            stockcost.Text = ListStockDB.getThisMonthTotalStockOutgoing(month, year);
        }

        private void loadTotalOutgoingBtn_Click(object sender, EventArgs e)
        {
            if(monthCombo.Text == string.Empty || yearCombo.Text == string.Empty)
            {
                MessageBox.Show("Please enter a year and a month");
            }

            int monthName = 0;

            if (monthCombo.Text == "January")
                monthName = 1;
            else if (monthCombo.Text == "February")
                monthName = 2;
            else if (monthCombo.Text == "March")
                monthName = 3;
            else if (monthCombo.Text == "April")
                monthName = 4;
            else if (monthCombo.Text == "May")
                monthName = 5;
            else if (monthCombo.Text == "June")
                monthName = 6;
            else if (monthCombo.Text == "July")
                monthName = 7;
            else if (monthCombo.Text == "August")
                monthName = 8;
            else if (monthCombo.Text == "September")
                monthName = 9;
            else if (monthCombo.Text == "Octorber")
                monthName = 10;
            else if (monthCombo.Text == "November")
                monthName = 11;
            else if (monthCombo.Text == "December")
                monthName = 12;

            loadOutgoingSalDetails(monthCombo.Text, yearCombo.Text);
            getStockTotalOutgoing(Convert.ToString(monthName), yearCombo.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }

}
