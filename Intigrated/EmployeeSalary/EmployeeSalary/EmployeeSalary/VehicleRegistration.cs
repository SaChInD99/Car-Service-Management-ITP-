using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class VehicleRegistration : Form
    {
        public VehicleRegistration()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csm;Sslmode=none;");
        MySqlCommand cmd;
        String sql;
        bool Mode = true;

        //fix rectangle curves 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nwidthEllipse,
                int nHightEllise
            );

        private void Form1_Load(object sender, EventArgs e)
        {
            //fix rectangle curves
            // button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));

            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }


       
        //Inserting Function
        private void InsertDetails()
        {
            string Vnum = textVno.Text;
            string Vcol = textVcol.Text;
            string Vtyp = textVtyp.Text;
            string VCon = comboBoxVcon.SelectedItem.ToString();
            string NIC = textNIC.Text;

            if (Mode == true)
            {
                sql = "insert into vehicle_table(Vid,Vehicle_num,Vcol,Vtype,Vcon,NIC) values(Null,@Vehicle_num,@Vcol,@Vtype,@Vcon,@NIC)";
               
                con.Open(); //Open Connection
                cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Vehicle_num", Vnum);
                cmd.Parameters.AddWithValue("@Vcol", Vcol);
                cmd.Parameters.AddWithValue("@Vtype", Vtyp);
                cmd.Parameters.AddWithValue("@Vcon", VCon);
                cmd.Parameters.AddWithValue("@NIC", NIC);
               
                cmd.ExecuteNonQuery();

                MessageBox.Show("All Vehicle Details are Recorded Successfuly.");


                //After Add the Vehicle Record we have to Clear the text fiealds
                textVno.Clear();
                textVcol.Clear();
                textVtyp.Clear();
                textNIC.Clear();
                textVno.Focus();
                comboBoxVcon.ResetText();


            }
            else
            {
                MessageBox.Show("!! Details are NOT Recorded Successfuly. !!");

            }

            con.Close();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            new BackupTesting().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleHome VM = new VehicleHome();
            VM.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //Validation For Inserting
        private void validateDetails()
        {
            if (textVno.Text == "")
            {
                MessageBox.Show("Enter Vehicle number");
            }
            else if (textVcol.Text == "")
            {
                MessageBox.Show("Enter Vehicle Colour");
            }
            else if (textVtyp.Text == "")
            {
                MessageBox.Show("Enter Vehicle Type");
            }
            else if (comboBoxVcon.SelectedItem == null)
            {
                MessageBox.Show("Enter Vehicle Condition");
            }
            else if (textNIC.Text == "")
            {
                MessageBox.Show("Enter Customer NIC");
            }
            else
            {
                InsertDetails();
            }
        }
        private void buttonsave_Click(object sender, EventArgs e)
        {

            validateDetails();
        }

        private void buttonnxt_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateVehicle VM = new UpdateVehicle();
            VM.Show();
        }
    }
}
