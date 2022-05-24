using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter your username");
                return; ;
            }

            String resUname = DbEmployee.validateUsername(textBox1.Text);
           if(textBox1.Text != resUname)
            {
                MessageBox.Show("Invalid Username");
                return; ;
            }

            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please enter your password");
                return; ;
            }

            String resPass = DbEmployee.validateUsernameAndPassword(resUname, textBox2.Text);

            if (textBox2.Text != resPass)
            {
                MessageBox.Show("Invalid Password");
                return; ;
            }

            MessageBox.Show("Logging Success!");
            this.Hide();
            MainDash VM = new MainDash();
            VM.Show();


        }
    }
}
