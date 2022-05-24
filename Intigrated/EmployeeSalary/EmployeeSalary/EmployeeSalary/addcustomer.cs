using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class addcustomer : Form
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
        private readonly maincustomermanage _parent;
        public string id,arr_Year, arr_Month, arr_Time, bID, nIC, customer_Name, address, email, contact_No, vehicle_num;

        public addcustomer(maincustomermanage parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            lbltext.Text = "Update Customer Details";
            btnSave.Text = "Update";
            tbArrivalYear.Text = arr_Year;
            tbArrivalMonth.Text = arr_Month;
            tbArrivalTime.Text = arr_Time;
            tbBookingID.Text = bID;
            tbNIC.Text = nIC;
            tbCustomername.Text = customer_Name;
            tbAddress.Text = address;
            tbEmail.Text = email;
            tbContact.Text = contact_No;
            tbVehicle.Text = vehicle_num;


        }

        public void SaveInfo()
        {
            lbltext.Text = "Add Customer Details";
            btnSave.Text = "Save";
        }
        public void Clear()
        {
            tbArrivalYear.Text = tbArrivalMonth.Text = tbArrivalTime.Text = tbBookingID.Text = tbNIC.Text = tbCustomername.Text = tbAddress.Text = tbEmail.Text = tbContact.Text = tbVehicle.Text = string.Empty;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbArrivalYear.Text.Trim().Length < 1)
            {
                MessageBox.Show("Arrival Year Is Empty ( > 1)");
                return;
            }
            if (tbArrivalMonth.Text.Trim().Length < 1)
            {
                MessageBox.Show("Arrival Month is Empty ( > 1)");
                return;
            }
            if (tbArrivalTime.Text.Trim().Length < 1)
            {
                MessageBox.Show("Arrival Time is Empty ( > 1)");
                return;
            }

            if (tbNIC.Text.Trim().Length < 1)
            {
                MessageBox.Show("Customer NIC is Empty ( > 1)");
                return;
            }
            int check = tbNIC.Text.Length;
            String nic = tbNIC.Text;

            if((check == 10) || (check == 12))
            {
                if(check == 10)
                {
                    for(int i = 0; i < check-1; i++)
                    {
                        try
                        {
                            int temp = Convert.ToInt32(Convert.ToString(nic[i]));
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("There Cannot be characters in the middle of the NIC");
                            return;
                        }
                    }

                    if(!(nic[check-1]=='v' || nic[check - 1] == 'V'))
                    {
                        MessageBox.Show("Invalid NIC");
                        return;
                    }
                }

                if (check == 12)
                {
                    for (int i = 0; i < check; i++)
                    {
                        try
                        {
                            int temp = Convert.ToInt32(Convert.ToString(nic[i]));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There Cannot be characters in the middle of the NIC");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid NIC");
                return;
            }

            if (tbCustomername.Text.Trim().Length < 1)
            {
                
                MessageBox.Show("Please fill the customer name!!");
                return;
            }

            
            if (tbAddress.Text.Trim().Length < 1)
            {
                MessageBox.Show("Customer Address is Empty ( > 3)");
                return;
            }
            if (tbEmail.Text.Trim().Length < 1)
            {
                MessageBox.Show("Email Address is Empty");
                return;
            }
            if (tbContact.Text.Trim().Length != 10)
            {
                MessageBox.Show("Please enter valid contact number(length = 10)");
                return;
            }
            if (tbVehicle.Text.Trim().Length < 1)
            {
                MessageBox.Show("Vehicle No is Empty ( > 3)");
                return;
            }

            if (btnSave.Text == "Save")
            {
               
                Customer cus = new Customer(tbArrivalYear.Text.Trim(), tbArrivalMonth.Text.Trim(), tbArrivalTime.Text.Trim(), tbBookingID.Text.Trim(), tbNIC.Text.Trim(), tbCustomername.Text.Trim(), tbAddress.Text.Trim(), tbEmail.Text.Trim(), tbContact.Text.Trim(), tbVehicle.Text.Trim());
                DbCustomer.AddCustomer(cus);
                Clear();
            }

            if (btnSave.Text == "Update")
            { 
                Customer cus = new Customer(tbArrivalYear.Text.Trim(), tbArrivalMonth.Text.Trim(), tbArrivalTime.Text.Trim(), tbBookingID.Text.Trim(), tbNIC.Text.Trim(), tbCustomername.Text.Trim(), tbAddress.Text.Trim(), tbEmail.Text.Trim(), tbContact.Text.Trim(), tbVehicle.Text.Trim());
                DbCustomer.UpdateCustomer(cus,id);
            }
            _parent.Display();


        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        
        


        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void getDateBtn_Click(object sender, EventArgs e)
        {
            string monthNo = DateTime.Now.Month.ToString();
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

            tbArrivalYear.Text = DateTime.Now.Year.ToString();
            tbArrivalMonth.Text = monthName;
            int dno = Convert.ToInt32(DateTime.Now.Day.ToString());
            String dch = Convert.ToString(dno);
            if (dno < 10)
            {
                dch = "0" + dch;
            }
            //tbArrivalTime.Text = "0"+DateTime.Now.Day.ToString() + " | " +DateTime.Now.Hour.ToString() +" : " + DateTime.Now.Minute.ToString();
            tbArrivalTime.Text = dch + " | " +DateTime.Now.Hour.ToString() +" : " + DateTime.Now.Minute.ToString();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {

            if(tbNIC.Text == string.Empty)
            {
                MessageBox.Show("Please input your NIC");
                return;
            }

            String check = DbCustomer.getCusDetails("Customer_Name", tbNIC.Text);

            if(check == string.Empty)
            {
                MessageBox.Show("Customer not found!");
                return;
            }

            tbCustomername.Text = check;
            tbAddress.Text = DbCustomer.getCusDetails("Address", tbNIC.Text);
            tbEmail.Text = DbCustomer.getCusDetails("Email", tbNIC.Text);
            tbContact.Text = DbCustomer.getCusDetails("Contact_No", tbNIC.Text);
        }
        //email validation part
        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(tbEmail.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email.");
                return;
            }
        }

        private void addcustomer_Load(object sender, EventArgs e)
        {
            //fix rectangle curves
            btnGet.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnGet.Width, btnGet.Height, 12, 12));
            btnSave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 12, 12));
            btnReset.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnReset.Width, btnReset.Height, 12, 12));
            getDateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, getDateBtn.Width, getDateBtn.Height, 12, 12));

            tbBookingID.Text = "none";
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtBookingID_Click(object sender, EventArgs e)
        {

        }

        private void txtVehicleno_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerNIC_Click(object sender, EventArgs e)
        {

        }

        private void txtArrivalTime_Click(object sender, EventArgs e)
        {

        }

        private void txtArrivalDay_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
