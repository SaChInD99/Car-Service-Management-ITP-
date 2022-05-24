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
using System.Windows.Forms.DataVisualization.Charting;

namespace EmployeeSalary
{

    public partial class FormEmployee : Form
    {
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

        FormEmployeeD form;


        public FormEmployee()
        {
            InitializeComponent();
            form = new FormEmployeeD(this);
        }

        public void Display()
        {
            DbEmployee.DisplayAndSearch("SELECT ID,EmployeeName, EmployeeID, NIC,DOB,Adress, EmployeeEmail ,ContactNumber, Attendence, OT FROM employee", dataGridView);
            loadAttendanceChart();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormEmployeeD form = new FormEmployeeD(this);
            form.ShowDialog();
        }

        private void FormEmployeeSalary_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbEmployee.DisplayAndSearch("SELECT ID,EmployeeName, EmployeeID,NIC,DOB,Adress, EmployeeEmail , ContactNumber, Attendence,OT FROM employee WHERE EmployeeID LIKE'%" + txtSearch.Text + "%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //MessageBox.Show(Convert.ToString(e.ColumnIndex));
            //return;
            if(e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.EmployeeName = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.EmployeeID = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.NIC = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.DOB = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.Adress = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.EmployeeEmail = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.ContactNumber = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.Attendence = dataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.OT = dataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                //Edit Button
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Are you want to delete EmployeeSalary  Details ?"," Warning",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Delete Button
                    DbEmployee.DeleteEmployee(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormEmployee_Load_1(object sender, EventArgs e)
        {
            btnNew.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNew.Width, btnNew.Height, 5, 5));
            //loadAttendanceChart();

            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new EmployeeReport().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainDash = new MainDash();
            MainDash.Closed += (s, args) => this.Close();
            MainDash.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainDash = new MainDash();
            MainDash.Closed += (s, args) => this.Close();
            MainDash.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BackupTesting().ShowDialog();
        }

        public void loadAttendanceChart()
        {
            //MessageBox.Show(dataGridView.Rows[0].Cells[10].Value.ToString());

            chartAttendance.Series.Clear();
            chartAttendance.Series.Add("Attendance");
            chartAttendance.Series["Attendance"].ChartType = SeriesChartType.Doughnut;

            int rowCount = dataGridView.RowCount;
             int over0 = 0;
             int over15 = 0;
             int over20 = 0;
             int over23 = 0;
             int over26 = 0;

             for (int i = 0; i < rowCount; i++)
             {
                 int currentCellData = Convert.ToInt32(dataGridView.Rows[i].Cells[10].Value.ToString());

                if (currentCellData < 15)
                 {
                     over0 += currentCellData;
                 }
                 else if (currentCellData < 20)
                 {
                     over15 += currentCellData;
                 }
                 else if (currentCellData < 23)
                 {
                     over20 += currentCellData;
                 }
                 else if (currentCellData < 26)
                 {
                     over23 += currentCellData;
                 }
                 else
                 {
                     over26 += currentCellData;
                 }
             }

            chartAttendance.Series["Attendance"].Points.AddXY("0 - 15", over0);
             chartAttendance.Series["Attendance"].Points.AddXY("15 - 20", over15);
             chartAttendance.Series["Attendance"].Points.AddXY("20 - 23", over20);
             chartAttendance.Series["Attendance"].Points.AddXY("23 - 26", over23);
             chartAttendance.Series["Attendance"].Points.AddXY("Over 26", over26);
        }

        private void btnchart_Click(object sender, EventArgs e)
        {
           // loadAttendanceChart();
        }
    }
}
