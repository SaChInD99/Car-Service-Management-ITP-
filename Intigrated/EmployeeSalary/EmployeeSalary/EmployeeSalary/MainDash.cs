using EmployeeSalary;
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
    public partial class MainDash : Form
    {
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

        public MainDash()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OutgoingDash = new OutgoingDash();
            OutgoingDash.Closed += (s, args) => this.Close();
            OutgoingDash.Show();
        }

        private void x_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmployee VM = new FormEmployee();
            VM.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Bill().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new CurrentStock().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Suppliermanage.supplierlist().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleHome VM = new VehicleHome();
            VM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new BK_Main().ShowDialog();
        }

        private void MainDash_Load(object sender, EventArgs e)
        {
            int s = 25;
            CusPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, CusPanel.Width, CusPanel.Height, s, s));
            BookingPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BookingPanel.Width, BookingPanel.Height, s, s));
            VehiclePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, VehiclePanel.Width, VehiclePanel.Height, s, s));
            IncomePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, IncomePanel.Width, IncomePanel.Height, s, s));
            panel12.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel12.Width, panel12.Height, s, s));

            loadDashIncomeDetails();
            loadDashCustomerDetails();
        }

        private void RefreshDash_Click(object sender, EventArgs e)
        {
            //getThisDayTotalIncome
            loadDashIncomeDetails();
            loadDashCustomerDetails();
        }
        
        public void loadDashIncomeDetails()
        {
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

            int i = IncomeDB.getThisDayTotalIncome(Convert.ToString(DateTime.Now.Day), monthName, Convert.ToString(DateTime.Now.Year));
            todayIncomeTot.Text = "Rs. " + Convert.ToString(i);
        }

        public void loadDashCustomerDetails()
        {
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
                monthName = "October";
            else if (monthN == 11)
                monthName = "November";
            else if (monthN == 12)
                monthName = "December";
            else
                monthName = "Not found";

            todayCusCount.Text = IncomeDB.getCustomerCount("0" + Convert.ToString(DateTime.Now.Day), monthName, Convert.ToString(DateTime.Now.Year));
            todayVehicleCount.Text = IncomeDB.getVehicleCount("0" + Convert.ToString(DateTime.Now.Day), monthName, Convert.ToString(DateTime.Now.Year));
            todayBookingCount.Text = IncomeDB.getTotBooking(Convert.ToString(DateTime.Now.Day), monthName);
        }

        private void timerDash_Tick(object sender, EventArgs e)
        {
            TimeTxt.Text = DateTime.Now.ToLongTimeString();
            DateTxt.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new maincustomermanage();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }
    }
}
