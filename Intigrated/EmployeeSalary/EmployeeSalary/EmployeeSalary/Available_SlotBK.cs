using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class Available_SlotBK : Form
    {
        public Available_SlotBK()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //close button
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            string status = bookingtb.getServiceSlot(srchSlot.Text);
            if(status == "Slot A")
            {
                slotBbg.BackColor = Color.LightGreen;
                slotBtxt.BackColor = Color.LightGreen;
                slotBstatus.BackColor = Color.LightGreen;
                slotBstatus.Text = "Available";
                slotAbg.BackColor = Color.Pink;
                slotAtxt.BackColor = Color.Pink;
                slotAstatus.BackColor = Color.Pink;
                slotAstatus.Text = "Unavailable";
                /*
                slotAbg.BackColor = Color.LightGreen;
                slotAtxt.BackColor = Color.LightGreen;
                slotAstatus.BackColor = Color.LightGreen;
                slotAstatus.Text = "Available";
                slotBbg.BackColor = Color.Pink;
                slotBtxt.BackColor = Color.Pink;
                slotBstatus.BackColor = Color.Pink;
                slotBstatus.Text = "Unavailable";*/

            }
            else if(status == "Slot B")
            {
                slotAbg.BackColor = Color.LightGreen;
                slotAtxt.BackColor = Color.LightGreen;
                slotAstatus.BackColor = Color.LightGreen;
                slotAstatus.Text = "Available";
                slotBbg.BackColor = Color.Pink;
                slotBtxt.BackColor = Color.Pink;
                slotBstatus.BackColor = Color.Pink;
                slotBstatus.Text = "Unavailable";
                /*slotBbg.BackColor = Color.LightGreen;
                slotBtxt.BackColor = Color.LightGreen;
                slotBstatus.BackColor = Color.LightGreen;
                slotBstatus.Text = "Available";
                slotAbg.BackColor = Color.Pink;
                slotAtxt.BackColor = Color.Pink;
                slotAstatus.BackColor = Color.Pink;
                slotAstatus.Text = "Unavailable";*/
            }
            else
            {
                slotAbg.BackColor = Color.LightGreen;
                slotAtxt.BackColor = Color.LightGreen;
                slotAstatus.BackColor = Color.LightGreen;
                slotAstatus.Text = "Available";
                slotBbg.BackColor = Color.LightGreen;
                slotBtxt.BackColor = Color.LightGreen;
                slotBstatus.BackColor = Color.LightGreen;
                slotBstatus.Text = "Available";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void slotAtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void slotAbg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slotAstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void slotBtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void slotBbg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slotBstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void srchSlot_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Available_SlotBK_Load(object sender, EventArgs e)
        {

        }
    }
}
