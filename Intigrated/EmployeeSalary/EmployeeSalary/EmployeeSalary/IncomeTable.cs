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
    public partial class IncomeTable : Form
    {

        public String parseVal1;
        public String parseVal2;

        AddNewIncome formAdd;

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

        public IncomeTable()
        {
            InitializeComponent();
            formAdd = new AddNewIncome(this);
        }

        public void displayGrid()
        {
            string qr = "select S_ID, CustomerID, CustomerName, VehicleID, Time, Day, Month, Year, PaymenthM, Price from " + IncomeDB.tbl + "";
            IncomeDB.DisplayIncome(qr, dataGridView1);
        }

        private void btnAddNewIncomeT_Click(object sender, EventArgs e)
        {
            
            formAdd.clearText();
            formAdd.saveIncome();
            formAdd.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new BackupTesting().ShowDialog();
        }

        private void IncomeTable_Load(object sender, EventArgs e)
        {
            btnAddNewIncomeT.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAddNewIncomeT.Width, btnAddNewIncomeT.Height, 5, 5));
            IFMreport.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, IFMreport.Width, IFMreport.Height, 5, 5));

            yearLoadTxt.Text = DateTime.Now.Year.ToString();
            loadBarChart();

            paymentMethodChart();

            String monthNo = DateTime.Now.Month.ToString();
            String yearNo = DateTime.Now.Year.ToString();
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

            int x = IncomeDB.getThisMonthTotalIncome(monthName, yearNo);
            currentMonthTotLbl.Text = Convert.ToString(x);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelT.Text = DateTime.Now.ToLongTimeString();
            labelD.Text = DateTime.Now.ToLongDateString();
        }

        private void IncomeTable_Shown(object sender, EventArgs e)
        {
            displayGrid();
        }

        private void SeachITXT_TextChanged(object sender, EventArgs e)
        {
            if(!(coloumnCombo.Text == "S_ID" || coloumnCombo.Text == "CustomerID" || coloumnCombo.Text == "CustomerName" || coloumnCombo.Text == "VehicleID" || coloumnCombo.Text == "Day" || coloumnCombo.Text == "Month" || coloumnCombo.Text == "Year" || coloumnCombo.Text == "PaymenthM"))
            {
                MessageBox.Show("Invalid Column Name!");
                return;
            }
            string qr = "select S_ID, CustomerID, CustomerName, VehicleID, Time, Day, Month, Year, PaymenthM, Price from "+IncomeDB.tbl+" where "+ coloumnCombo.Text+ " like '%"+SeachITXT.Text+"%'";
            IncomeDB.DisplayIncome(qr, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                formAdd.clearText();
                string c1 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string c2 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string c3 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string c4 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                string c5 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                string c6 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                string c7 = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                string c8 = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                string c9 = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                string c10 = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                formAdd.updateIncome(c1, c2, c3, c4, c5, c6, c7, c8, c9, c10);
                formAdd.ShowDialog();
            }
            if(e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want want to delete this record?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    IncomeDB.DeleteIncome(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    displayGrid();
                }
            }
        }

        private void incomeLoadDataBtn_Click(object sender, EventArgs e)
        {
            loadBarChart();
        }

        public void loadBarChart()
        {
            yearlyIncomeChart.Series.Clear();
            yearlyIncomeChart.Series.Add("Monthly Total");

            if (yearLoadTxt.Text == string.Empty)
            {
                MessageBox.Show("Invalid Year");
                return;
            }
            string y = yearLoadTxt.Text;
            int iy = Convert.ToInt32(y);

            if (iy < 2000 || iy > 2100)
            {
                MessageBox.Show("Invalid Year");
                return;
            }

            int jan = IncomeDB.getThisMonthTotalIncome("January", y);
            januaryTxt.Text = Convert.ToString(jan);

            int feb = IncomeDB.getThisMonthTotalIncome("February", y);
            februaryTxt.Text = Convert.ToString(feb);

            int mar = IncomeDB.getThisMonthTotalIncome("March", y);
            marchTxt.Text = Convert.ToString(mar);

            int apr = IncomeDB.getThisMonthTotalIncome("April", y);
            aprilTxt.Text = Convert.ToString(apr);

            int may = IncomeDB.getThisMonthTotalIncome("May", y);
            mayTxt.Text = Convert.ToString(may);

            int jun = IncomeDB.getThisMonthTotalIncome("June", y);
            juneTxt.Text = Convert.ToString(jun);

            int jul = IncomeDB.getThisMonthTotalIncome("July", y);
            julyTxt.Text = Convert.ToString(jul);

            int aug = IncomeDB.getThisMonthTotalIncome("August", y);
            augustTxt.Text = Convert.ToString(aug);

            int sep = IncomeDB.getThisMonthTotalIncome("September", y);
            septemberTxt.Text = Convert.ToString(sep);

            int oct = IncomeDB.getThisMonthTotalIncome("Octorber", y);
            octorberTxt.Text = Convert.ToString(oct);

            int nov = IncomeDB.getThisMonthTotalIncome("November", y);
            novemberTxt.Text = Convert.ToString(nov);

            int dec = IncomeDB.getThisMonthTotalIncome("December", y);
            decemberTxt.Text = Convert.ToString(dec);

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("Jan", jan);
            yearlyIncomeChart.Series["Monthly Total"].Points[0].Color = Color.SlateBlue;

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("Feb", feb);
            yearlyIncomeChart.Series["Monthly Total"].Points[1].Color = Color.CadetBlue;

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("Mar", mar);
            yearlyIncomeChart.Series["Monthly Total"].Points[2].Color = Color.CornflowerBlue;

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("Apr", apr);
            yearlyIncomeChart.Series["Monthly Total"].Points[3].Color = Color.Orchid;

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("May", may);
            yearlyIncomeChart.Series["Monthly Total"].Points[4].Color = Color.Violet;

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("Jun", jun);
            yearlyIncomeChart.Series["Monthly Total"].Points[5].Color = Color.Pink;

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("Jul", jul);
            yearlyIncomeChart.Series["Monthly Total"].Points[6].Color = Color.Salmon;

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("Aug", aug);
            yearlyIncomeChart.Series["Monthly Total"].Points[7].Color = Color.Coral;

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("Sep", sep);
            yearlyIncomeChart.Series["Monthly Total"].Points[8].Color = Color.Gold;

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("Oct", oct);
            yearlyIncomeChart.Series["Monthly Total"].Points[9].Color = Color.Tan;

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("Nov", nov);
            yearlyIncomeChart.Series["Monthly Total"].Points[10].Color = Color.Silver;

            yearlyIncomeChart.Series["Monthly Total"].Points.AddXY("Dec", dec);
            yearlyIncomeChart.Series["Monthly Total"].Points[11].Color = Color.Gray;
        }

        public void paymentMethodChart()
        {
            int pmc = IncomeDB.getAvgPaymentMethods("Cash");
            int pmch = IncomeDB.getAvgPaymentMethods("Cheque");
            int pmv = IncomeDB.getAvgPaymentMethods("Visa");
            int pmm = IncomeDB.getAvgPaymentMethods("Master");

            PmethodAvgChart.Series["payment"].Points.AddXY("Cash", pmc);
            PmethodAvgChart.Series["payment"].Points.AddXY("Cheque", pmch);
            PmethodAvgChart.Series["payment"].Points.AddXY("Visa", pmv);
            PmethodAvgChart.Series["payment"].Points.AddXY("Master", pmm);
        }

        private void IFMreport_Click(object sender, EventArgs e)
        {
            new IncomeFinanceMonthlyReport().ShowDialog();
        }
    }
}
