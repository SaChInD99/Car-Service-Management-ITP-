using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class PrintVehicle : Form
    {
        public PrintVehicle()
        {
            InitializeComponent();
            load();
        }

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csm;Sslmode=none;");
        MySqlCommand cmd;
        MySqlDataReader dr;
        String sql;

        private void ViewVehicle_Load(object sender, EventArgs e)
        {

            
        }
        
       
        public void load()
        {
            sql = "select * from vehicle_table";
            cmd = new MySqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);

            }

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleHome VM = new VehicleHome();
            VM.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }
        Bitmap bmp;
        private void button7_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(bmp, 0, 0);
        }

        
    }
}
