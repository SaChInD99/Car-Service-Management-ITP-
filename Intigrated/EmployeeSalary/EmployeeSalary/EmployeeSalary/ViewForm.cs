using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class ViewForm : Form
    {
        private readonly BK_Main _parent;
        public ViewForm(BK_Main parent)
        {
            InitializeComponent();
            _parent = parent;
        }

     

        public void fillText(string f1, string f2, string f3, string f4, string f5)
        {
            txtBID.Text = f1;
            txtNIC.Text = f2;
            txtC_Name.Text = f3;
            txtContact_No.Text = f4;
            txtVehicle_No.Text = f5;
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text== "abc@gmail.com")
            {
                txtEmail.Text = "";
                ForeColor = Color.Black;
                    
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "abc@gmail.com";
                ForeColor = Color.DarkGray;

            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            statusBox.BackColor = Color.Gainsboro;
            statusBox.Text = "";

            if (txtMonth.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "Day is Empty ";
                return;
            }
            if (txtDay.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "Day is Empty ";
                return;
            }
            if (txtTime.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "Time is Empty ";
                return;
            }

        
            if (txtAddress.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "B_Type is Empty ";
                return;
            }
            
           
            if (txtEmail.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "Service slot is Empty ";
                return;
            }
            if (btnSave.Text == "Submit")
            {
              //  booking bk = new booking(txtC_Name.Text.Trim(), txtContact_No.Text.Trim(), txtVehicle_No.Text.Trim(), txtNIC.Text.Trim(), txtMonth.Text.Trim(), txtDay.Text.Trim(), txtTime.Text.Trim());
              //  bookingtb.Addbooking(bk);
                
            }
        }
    }
}
