using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class EmployeeSalaryChart : Form
    {
        public EmployeeSalaryChart()
        {
            InitializeComponent();
        }

        private void Load_Chart_Click(object sender, EventArgs e)
        {
            loadSalaryChart();
        }

        private void EmployeeSalaryChart_Load(object sender, EventArgs e)
        {
            loadYearTxt.Text = DateTime.Now.Year.ToString();
            loadSalaryChart();
        }

        public void loadSalaryChart()
        {
            salaryChart.Series.Clear();
            salaryChart.Series.Add("Monthly Salary");

            int jan = DbEmployeeS.getMonthlyTolalSalary("January", loadYearTxt.Text);
            int feb = DbEmployeeS.getMonthlyTolalSalary("February", loadYearTxt.Text);
            int mar = DbEmployeeS.getMonthlyTolalSalary("March", loadYearTxt.Text);
            int apr = DbEmployeeS.getMonthlyTolalSalary("April", loadYearTxt.Text);
            int may = DbEmployeeS.getMonthlyTolalSalary("May", loadYearTxt.Text);
            int jun = DbEmployeeS.getMonthlyTolalSalary("June", loadYearTxt.Text);
            int jul = DbEmployeeS.getMonthlyTolalSalary("July", loadYearTxt.Text);
            int aug = DbEmployeeS.getMonthlyTolalSalary("August", loadYearTxt.Text);
            int sep = DbEmployeeS.getMonthlyTolalSalary("September", loadYearTxt.Text);
            int oct = DbEmployeeS.getMonthlyTolalSalary("Octorber", loadYearTxt.Text);
            int nov = DbEmployeeS.getMonthlyTolalSalary("November", loadYearTxt.Text);
            int dec = DbEmployeeS.getMonthlyTolalSalary("December", loadYearTxt.Text);

            salaryChart.Series["Monthly Salary"].Points.AddXY("Jan", jan);
            salaryChart.Series["Monthly Salary"].Points[0].Color = Color.SlateBlue;

            salaryChart.Series["Monthly Salary"].Points.AddXY("Feb", feb);
            salaryChart.Series["Monthly Salary"].Points[1].Color = Color.CadetBlue;

            salaryChart.Series["Monthly Salary"].Points.AddXY("Mar", mar);
            salaryChart.Series["Monthly Salary"].Points[2].Color = Color.CornflowerBlue;

            salaryChart.Series["Monthly Salary"].Points.AddXY("Apr", apr);
            salaryChart.Series["Monthly Salary"].Points[3].Color = Color.Orchid;

            salaryChart.Series["Monthly Salary"].Points.AddXY("May", may);
            salaryChart.Series["Monthly Salary"].Points[4].Color = Color.Violet;

            salaryChart.Series["Monthly Salary"].Points.AddXY("Jun", jun);
            salaryChart.Series["Monthly Salary"].Points[5].Color = Color.Pink;

            salaryChart.Series["Monthly Salary"].Points.AddXY("Jul", jul);
            salaryChart.Series["Monthly Salary"].Points[6].Color = Color.Salmon;

            salaryChart.Series["Monthly Salary"].Points.AddXY("Aug", aug);
            salaryChart.Series["Monthly Salary"].Points[7].Color = Color.Coral;

            salaryChart.Series["Monthly Salary"].Points.AddXY("Sep", sep);
            salaryChart.Series["Monthly Salary"].Points[8].Color = Color.Gold;

            salaryChart.Series["Monthly Salary"].Points.AddXY("Oct", oct);
            salaryChart.Series["Monthly Salary"].Points[9].Color = Color.Tan;

            salaryChart.Series["Monthly Salary"].Points.AddXY("Nov", nov);
            salaryChart.Series["Monthly Salary"].Points[10].Color = Color.Silver;

            salaryChart.Series["Monthly Salary"].Points.AddXY("Dec", dec);
            salaryChart.Series["Monthly Salary"].Points[11].Color = Color.Gray;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormEmployeeSalary = new FormEmployeeSalary();
            FormEmployeeSalary.Closed += (s, args) => this.Close();
            FormEmployeeSalary.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BackupTesting().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainDash = new MainDash();
            MainDash.Closed += (s, args) => this.Close();
            MainDash.Show();
        }
    }
}
