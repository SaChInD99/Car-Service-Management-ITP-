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
    public partial class BK_Main : Form
    {
        Add_NewBK form;
        ViewForm form1;

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

        public BK_Main()
        {
            InitializeComponent();
            form = new Add_NewBK(this);
            form1 = new ViewForm(this);
        }
        public void Display()
        {
            bookingtb.DisplayAndSearch("SELECT BID, C_Name, Contact_No, Vehicle_No, NIC, B_type, Time, Day, Month, Service_Slot FROM bookingtb", dataGridView1);
            loadTimeBookingCount();


        }

        //close Button
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.AddInfo();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            //fix rectangle curves
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Available_SlotBK().ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Search
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(dbColumns.Text == string.Empty)
            {
                MessageBox.Show("Column field can no be empty");
                return;
            }
            bookingtb.DisplayAndSearch("SELECT BID, C_Name, Contact_No, Vehicle_No, NIC, B_type, Time, Day, Month, Service_Slot FROM bookingtb WHERE "+ dbColumns.Text +" LIKE '%" + textBox5.Text+"%'", dataGridView1);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Display();
        }

        //edit
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                form.Clear();
                string a1 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string a2 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                string a3 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                string a4 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                string a5 = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                string a6 = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                string a7 = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                string a8 = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                string a9 = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                string a10 = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                form.Update(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10);
                form.ShowDialog();
             
                return;
            }
            if (e.ColumnIndex == 3)
            {
               //Delete
                if (MessageBox.Show("Are you want to delete student recode?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes);
                {
                    bookingtb.Deletebooking(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    Display();
                }
                return;
            }
            if (e.ColumnIndex == 1)
            {
                string a1 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string a5 = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                string a2 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                string a3 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                string a4 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form1.fillText(a1, a5, a2, a3, a4);
                form1.ShowDialog();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void dbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(bookingtb.getServiceSlot("13"));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void srchSlot_TextChanged(object sender, EventArgs e)
        {

        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            string status = bookingtb.getServiceSlot(srchSlot.Text);
            if (status == "Slot A")
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
            else if (status == "Slot B")
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

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new BookingReport().ShowDialog();
        }

        private void BK_Main_Load(object sender, EventArgs e)
        {
            dbColumns.Text = "Time";
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 15, 15));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 15, 15));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 15, 15));
            button8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button8.Width, button8.Height, 15, 15));
            pnl1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl1.Width, pnl1.Height, 30, 30));
            pnl2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl2.Width, pnl2.Height, 30, 30));
            pnl3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl3.Width, pnl3.Height, 30, 30));
            pnl4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl4.Width, pnl4.Height, 30, 30));
            pnl5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl5.Width, pnl5.Height, 30, 30));
            pnl6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl6.Width, pnl6.Height, 30, 30));

            timer1.Start();
            label2.Text = DateTime.Now.ToLongDateString();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void pnl5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadTimeBookingCount()
        {
            int count = dataGridView1.RowCount;
            int c1 = 0;
            int c2 = 0;
            int c3 = 0;
            int c4 = 0;
            int c5 = 0;
            int c6 = 0;
            double cellTime = 0;

            for (int i = 0; i < count; i++)
            {
                cellTime = Convert.ToDouble(dataGridView1.Rows[i].Cells[10].Value.ToString());

                if (cellTime < 8)
                {

                }
                else if (cellTime < 10)
                    c1++;
                else if (cellTime < 12)
                    c2++;
                else if (cellTime < 14)
                    c3++;
                else if (cellTime < 16)
                    c4++;
                else if (cellTime < 18)
                    c5++;
                else if (cellTime < 20)
                    c6++;

            }

            TSlot1.Text = Convert.ToString(c1);
            TSlot2.Text = Convert.ToString(c2);
            TSlot3.Text = Convert.ToString(c3);
            TSlot4.Text = Convert.ToString(c4);
            TSlot5.Text = Convert.ToString(c5);
            TSlot6.Text = Convert.ToString(c6);
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new BackupTesting().ShowDialog();
        }
    }
}
