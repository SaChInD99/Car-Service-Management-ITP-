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
    public partial class FormEmployeeSalary : Form
    {
        FormEmployeeS form;


        public FormEmployeeSalary()
        {
            InitializeComponent();
            form = new FormEmployeeS(this);
        }

        public void Display()
        {
            DbEmployeeS.DisplayAndSearch("SELECT ID,Year, Month, EmployeeSalaryID , EmployeeName, EmployeeID, EmployeeEmail , OT, ContactNumber, Basic, Attendence, CalculatedSalary FROM employees", dataGridView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormEmployeeS form = new FormEmployeeS(this);
            form.ShowDialog();
        }

        private void FormEmployeeSalary_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbEmployeeS.DisplayAndSearch("SELECT ID,Year, Month, EmployeeSalaryID , EmployeeName, EmployeeID, EmployeeEmail , OT, ContactNumber, Basic, Attendence, CalculatedSalary FROM employee WHERE EmployeeID LIKE'%" + txtSearch.Text + "%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.Year = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.Month = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.EmployeeSalaryID = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.EmployeeName = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.EmployeeID = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.EmployeeEmail = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.OT = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.ContactNumber = dataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.Basic = dataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
                form.Attendence = dataGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
                form.CalculatedSalary = dataGridView.Rows[e.RowIndex].Cells[13].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                //Edit Button
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Are you want to delete EmployeeSalary Salary Details ?","Data Deleting Warning",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Delete Button
                    DbEmployeeS.DeleteEmployeeSalary(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void FormEmployeeSalary_Load(object sender, EventArgs e)
        {

        }

        private void btnchartE_Click(object sender, EventArgs e)
        {
            this.Hide();
            var EmployeeSalaryChart = new EmployeeSalaryChart();
            EmployeeSalaryChart.Closed += (s, args) => this.Close();
            EmployeeSalaryChart.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void x_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRepo_Click(object sender, EventArgs e)
        {
            new EmployeeSalaryReportDetailForm().ShowDialog();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OutgoingDash = new OutgoingDash();
            OutgoingDash.Closed += (s, args) => this.Close();
            OutgoingDash.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            new FormEmployeeOutgoing().ShowDialog();
        }
    }
}