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
    public partial class VehicleHome : Form
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
                int nHightEllise
            );
    

    
        public VehicleHome()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //fix rectangle curves
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));
            button5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));
            button6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));
            button8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));

            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Calling Vehical Reg Page
            this.Hide();
            VehicleRegistration VM = new VehicleRegistration();
            VM.Show();
        }

        private void button5_click(object sender, EventArgs e)
        {
            //Calling Update Vehical Page
            this.Hide();
            UpdateVehicle VM = new UpdateVehicle();
            VM.Show();
        }

        private void button6_click(object sender, EventArgs e)
        {
            //Calling View Vehical Page
            this.Hide();
            ViewVehicle VM = new ViewVehicle();
            VM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calling  Vehical Home Page
            this.Hide();
            VehicleHome VM = new VehicleHome();
            VM.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            PrintVehicle VM = new PrintVehicle();
            VM.Show();

          
           
        }

        private void home_Click(object sender, EventArgs e)
        {
            new BackupTesting().ShowDialog();
        }
    }
}
