using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class FormEmployeeS2 : Form
    {
        private readonly FormEmployeeOutgoing _parent;
        public  string id,EmployeeSalaryID, EmployeeName, EmployeeID, EmployeeEmail, OT, ContactNumber, Basic, Attendence, CalculatedSalary, Month ,Year;

        private void FormEmployeeS_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double OT = double.Parse(txtOT.Text);
            double Basic = double.Parse(txtBasic.Text);
            double result = 0;
            result = OT + Basic;

            txtCalculatedSalary.Text = result.ToString();
        }

        public FormEmployeeS2(FormEmployeeOutgoing parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lbltext.Text = "Update Employee Salary";
            btnSave.Text = "Add";
            txtEmployeeSalaryID.Text = EmployeeSalaryID;
            txtEmployeeName.Text = EmployeeName;
            txtEmployeeID.Text = EmployeeID;
            txtEmployeeEmail.Text = EmployeeEmail;
            txtOT.Text = OT;
            txtContactNumber.Text = ContactNumber;
            txtBasic.Text = Basic;
            txtAttendence.Text = Attendence;
            txtCalculatedSalary.Text = CalculatedSalary;
            txtMonth.Text = Month;
            txtYear.Text = Year;
        }

        public void Clear()
        {
            txtEmployeeSalaryID.Text = txtEmployeeName.Text = txtEmployeeID.Text = txtEmployeeEmail.Text = txtOT.Text = txtContactNumber.Text = txtBasic.Text = txtAttendence.Text = txtCalculatedSalary.Text = txtMonth.Text = txtYear.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeSalaryID.Text.Trim().Length < 3)
            {
                MessageBox.Show("EmployeeSalary Salary ID is Empty ( >3 ).");
                return;
            }
            if (txtEmployeeName.Text.Trim().Length < 3)
            {
                MessageBox.Show("EmployeeSalary Name is Empty ( >3 ).");
                return;
            }
            if (txtEmployeeID.Text.Trim().Length < 3)
            {
                MessageBox.Show("EmployeeSalary ID is Empty ( >3 ).");
                return;
            }
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(txtEmployeeEmail.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email.");
                return;
            }
            if (txtOT.Text.Trim().Length < 3)
            {
                MessageBox.Show("EmployeeSalary OT is Empty ( >3 ).");
                return;
            }
            if (txtContactNumber.Text.Trim().Length != 10)
            {
                MessageBox.Show("Please Input 10 digit contact number ( >10 ).");
                return;
            }
            if (txtBasic.Text.Trim().Length < 3)
            {
                MessageBox.Show("EmployeeSalary Basic Salary is Empty ( >3 ).");
                return;
            }
            if (txtAttendence.Text.Trim().Length < 1)
            {
                MessageBox.Show("EmployeeSalary Attendence is Empty ( >1 ).");
                return;
            }
            if (txtCalculatedSalary.Text.Trim().Length < 3)
            {
                MessageBox.Show("EmployeeSalary Calculated Salary is Empty ( >3 ).");
                return;
            }
            if(btnSave.Text == "Save")
            {
                EmployeeSalary std = new EmployeeSalary(txtEmployeeSalaryID.Text.Trim(), txtEmployeeName.Text.Trim(), 
                    txtEmployeeID.Text.Trim(), txtEmployeeEmail.Text.Trim(), txtOT.Text.Trim(), txtContactNumber.Text.Trim(), 
                    txtBasic.Text.Trim(), txtAttendence.Text.Trim(), txtCalculatedSalary.Text.Trim(),txtMonth.Text.Trim(), txtYear.Text.Trim());
                DbEmployeeS.AddEmployeeS(std);
                Clear();
            }
            if(btnSave.Text == "Add")
            {
                EmployeeSalary std = new EmployeeSalary(txtEmployeeSalaryID.Text.Trim(), txtEmployeeName.Text.Trim(),
                    txtEmployeeID.Text.Trim(), txtEmployeeEmail.Text.Trim(), txtOT.Text.Trim(), txtContactNumber.Text.Trim(),
                    txtBasic.Text.Trim(), txtAttendence.Text.Trim(), txtCalculatedSalary.Text.Trim(),txtMonth.Text.Trim(), txtYear.Text.Trim());
                DbEmployeeS.UpdateEmployeeS2(std, id);
            }
            _parent.Display();
        }
    }
}