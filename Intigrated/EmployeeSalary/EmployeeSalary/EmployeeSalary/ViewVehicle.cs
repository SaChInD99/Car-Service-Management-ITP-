using MySql.Data.MySqlClient;
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
    public partial class ViewVehicle : Form
    {
        public ViewVehicle()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
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

        private void Form2_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        void display()
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csm;Sslmode=none;");
            DataTable dt = new DataTable();


            if (textVid.Text.Length > 0)
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from vehicle_table where Vid LIKE '" + textVid.Text + "%'", con);
                sda.Fill(dt);

            }
            else if (textVno.Text.Length > 0)
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from vehicle_table where Vehicle_num LIKE '" + textVno.Text + "%'", con);
                sda.Fill(dt);
            }
            else if (textVCus.Text.Length > 0)
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from vehicle_table where NIC LIKE '" + textVCus.Text + "%'", con);
                sda.Fill(dt);
            }

            dataGridView1.DataSource = dt;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textVno.Text = "";
            textVCus.Text = "";
            display();
        }

        private void textVno_TextChanged(object sender, EventArgs e)
        {
            textVid.Text = "";
            textVCus.Text = "";
            display();
        }

        private void textVCus_TextChanged(object sender, EventArgs e)
        {
            textVid.Text = "";
            textVno.Text = "";
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleHome VM = new VehicleHome();
            VM.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textVCus.Clear();
            textVno.Clear();
            textVid.Clear();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            new BackupTesting().ShowDialog();
        }
    }
}
