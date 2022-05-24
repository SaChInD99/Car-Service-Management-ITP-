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
    public partial class OutgoingDash : Form
    {

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
        public OutgoingDash()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormEmployeeSalary = new FormEmployeeSalary();
            FormEmployeeSalary.Closed += (s, args) => this.Close();
            FormEmployeeSalary.Show();
        }

        private void x_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void OutgoingDash_Load(object sender, EventArgs e)
        {
            //fix rectangle curves
            btnEmployeeSalary.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEmployeeSalary.Width, btnEmployeeSalary.Height, 30, 30));
            btnStockCost.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnStockCost.Width, btnStockCost.Height, 30, 30));

            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        //mouse hovers
        private void btnEmployeeSalary_MouseEnter(object sender, EventArgs e)
        {
            btnEmployeeSalary.BackColor = Color.GreenYellow;
        }

        private void btnEmployeeSalary_MouseLeave(object sender, EventArgs e)
        {
            btnEmployeeSalary.BackColor = Color.WhiteSmoke;
        }
        private void btnStockCost_MouseEnter(object sender, EventArgs e)
        {
            btnStockCost.BackColor = Color.LightBlue;
        }
        private void btnStockCost_MouseLeave(object sender, EventArgs e)
        {
            btnStockCost.BackColor = Color.WhiteSmoke;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainDash = new MainDash();
            MainDash.Closed += (s, args) => this.Close();
            MainDash.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainDash = new MainDash();
            MainDash.Closed += (s, args) => this.Close();
            MainDash.Show();
        }

        private void btnStockCost_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OutgoingDetails = new OutgoingDetails();
            OutgoingDetails.Closed += (s, args) => this.Close();
            OutgoingDetails.Show();
        }
    }
}
