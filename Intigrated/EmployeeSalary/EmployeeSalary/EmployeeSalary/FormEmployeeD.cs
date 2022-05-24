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
    public partial class FormEmployeeD : Form
    {
        private readonly FormEmployee _parent;
        public  string id,EmployeeName, EmployeeID,NIC,DOB,Adress, EmployeeEmail, ContactNumber, Attendence,OT ;


        public FormEmployeeD(FormEmployee parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lbltext.Text = "Update EmployeeSalary Details";
            btnSave.Text = "Update";
            txtEmployeeName.Text = EmployeeName;
            txtEmployeeID.Text = EmployeeID;
            txtNIC.Text = NIC;
            txtDOB.Text = DOB;
            txtAdress.Text = Adress;
            txtEmployeeEmail.Text = EmployeeEmail;
            txtContactNumber.Text = ContactNumber;
            txtAttendence.Text = Attendence;
            txtOT.Text = OT;
        }

        public void Clear()
        {
            txtEmployeeName.Text = txtEmployeeID.Text = txtNIC.Text = txtDOB.Text = txtAdress.Text = txtEmployeeEmail.Text = txtAttendence.Text = txtOT.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            if (txtNIC.Text.Trim().Length < 3)
            {
                MessageBox.Show("EmployeeSalary NIC is Empty ( >3 ).");
                return;
            }
            if (txtDOB.Text.Trim().Length < 3)
            {
                MessageBox.Show("EmployeeSalary DOB is Empty ( >3 ).");
                return;
            }
            if (txtAdress.Text.Trim().Length < 3)
            {
                MessageBox.Show("EmployeeSalary Adress is Empty ( >3 ).");
                return;
            }
            if (txtEmployeeEmail.Text.Trim().Length < 3)
            {
                MessageBox.Show("EmployeeSalary Email is Empty ( >3 ).");
                return;
            }
            if (txtAttendence.Text.Trim().Length < 1)
            {
                MessageBox.Show("EmployeeSalary Attendence is Empty ( >1 ).");
                return;
            }
            if (txtContactNumber.Text.Trim().Length <10)
            {
                MessageBox.Show("Enter 10 digit contact number.");
                return;
            }
            if (txtOT.Text.Trim().Length < 2)
            {
                MessageBox.Show("EmployeeSalary OT is Empty ( >2 ).");
                return;
            }
            if (btnSave.Text == "Save")
            {
                Employee std = new Employee(txtEmployeeName.Text.Trim(), txtEmployeeID.Text.Trim(), txtNIC.Text.Trim(),
                    txtDOB.Text.Trim(), txtAdress.Text.Trim(), txtEmployeeEmail.Text.Trim(), txtContactNumber.Text.Trim(),
                    txtAttendence.Text.Trim(), txtOT.Text.Trim());
                DbEmployee.AddEmployee(std);
                Clear();
            }
            if(btnSave.Text == "Update")
            {
                Employee std = new Employee(txtEmployeeName.Text.Trim(), txtEmployeeID.Text.Trim(), txtNIC.Text.Trim(),
                    txtDOB.Text.Trim(), txtAdress.Text.Trim(), txtEmployeeEmail.Text.Trim(), txtContactNumber.Text.Trim(),
                    txtAttendence.Text.Trim(), txtOT.Text.Trim());
                DbEmployee.UpdateEmployee(std, id);
            }
            _parent.Display();
        }
    }
}