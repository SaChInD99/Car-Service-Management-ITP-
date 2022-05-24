using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmployeeSalary
{
    public partial class maincustomermanage : Form
    {

        addcustomer form;
        CompleteForm form1;
        CompleteTable2 form2;
        panel form3;

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

        public maincustomermanage()
        {
            InitializeComponent();
            form = new addcustomer(this);
            form1 = new CompleteForm(this);
            form3 = new panel(this);
        }

        public void Display()
        {
            //search details in the main customer management page
            DbCustomer.DisplayAndSearch("SELECT S_Code, Arr_Year, Arr_Month, Arr_Time, BID, NIC ,Customer_Name,Address,Email,Contact_No,Vehicle_num FROM customertable", table);

            //Display the customer count
            int f = DbCustomer.CustomerCount();
            currtxt.Text = Convert.ToString(f);

            //display the non booked customer count in the current table
            int d = DbCustomer.nonBookedCusCount();
            noncustxt.Text = Convert.ToString(d);

            //display the booked customer count
            int book = f - d;
            booktxtx.Text = Convert.ToString(book);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(0, 0);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            form.Clear();
            form.SaveInfo();
            form.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(mainNIC.Text == string.Empty)
            {
                MessageBox.Show("Please select a NIC");
                return;
            }
            String a1 = DbCustomer.getCusDetails("NIC", mainNIC.Text);
            if(a1 == string.Empty)
            {
                MessageBox.Show("Customer not found!");
                return;
            }
            String a2 = DbCustomer.getCusDetails("Customer_Name", mainNIC.Text);
            String a3 = DbCustomer.getCusDetails("Address", mainNIC.Text);
            String a4 = DbCustomer.getCusDetails("Contact_No", mainNIC.Text);
            String a5 = DbCustomer.getCusDetails("Email", mainNIC.Text);
            form3.addToProfile(a1, a2, a3, a4, a5);
            form3.ShowDialog();
            return;


        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            DbCustomer.DisplayAndSearch("SELECT S_Code, Arr_Year, Arr_Month, Arr_Time, BID, NIC ,Customer_Name,Address,Email,Contact_No,Vehicle_num FROM customertable WHERE "+ searchcombo .Text+ " LIKE'%" + textsearch.Text + "%'", table);
            //DbCustomer.DisplayAndSearch("SELECT S_Code, Arr_Year, Arr_Month, Arr_Time, BID, NIC ,Customer_Name,Address,Email,Contact_No,Vehicle_num FROM customertable WHERE "+ searchcombo .Text+ " LIKE'" + textsearch.Text + "%'", table);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDay.Text = DateTime.Now.ToLongDateString();
        }
        private void button1_Mousehover(object sender, EventArgs e)
        {
           
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Teal;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Custype_Click(object sender, EventArgs e)
        {

        }

        private void cmboAll_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            new CompleteTable2().ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 3)
            {

                form.Clear();
                //form.code = table.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.arr_Year= table.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.arr_Month= table.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.arr_Time = table.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.bID= table.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.nIC= table.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.customer_Name= table.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.address= table.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.email= table.Rows[e.RowIndex].Cells[11].Value.ToString();
                form.contact_No = table.Rows[e.RowIndex].Cells[12].Value.ToString();
                form.vehicle_num = table.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delete
                if (MessageBox.Show("Do you want to delete customer record??", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    
                    DbCustomer.DeleteCustomer(table.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
                return;
            }
            if (e.ColumnIndex == 2)
            {
                string f1 = table.Rows[e.RowIndex].Cells[4].Value.ToString();
                string f2 = table.Rows[e.RowIndex].Cells[5].Value.ToString();
                string f3 = table.Rows[e.RowIndex].Cells[6].Value.ToString();
                string f4 = table.Rows[e.RowIndex].Cells[7].Value.ToString();
                string f5 = table.Rows[e.RowIndex].Cells[8].Value.ToString();
                string f6 = table.Rows[e.RowIndex].Cells[9].Value.ToString();
                form1.addToCompleteTable(f1, f2, f3, f4,f5,f6);
                form1.ShowDialog();
                return;
            }


        }

        private void table_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(Convert.ToString(e.ColumnIndex));
            if (e.ColumnIndex == 0)
            {
                
                form.Clear();
                form.id = table.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.arr_Year = table.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.arr_Month = table.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.arr_Time = table.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.bID = table.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.nIC = table.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.customer_Name = table.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.address = table.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.email = table.Rows[e.RowIndex].Cells[11].Value.ToString();
                form.contact_No = table.Rows[e.RowIndex].Cells[12].Value.ToString();
                form.vehicle_num = table.Rows[e.RowIndex].Cells[13].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delete
                if (MessageBox.Show("Are you sure that you want to delete Customer record??", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    DbCustomer.DeleteCustomer(table.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
                return;
            }
            if (e.ColumnIndex == 2)
            {
                
                string f1 = table.Rows[e.RowIndex].Cells[3].Value.ToString();
                string f2 = table.Rows[e.RowIndex].Cells[8].Value.ToString();
                string f3 = table.Rows[e.RowIndex].Cells[9].Value.ToString();
                string f4 = table.Rows[e.RowIndex].Cells[13].Value.ToString();
                string f5 = table.Rows[e.RowIndex].Cells[4].Value.ToString();
                string f6 = table.Rows[e.RowIndex].Cells[5].Value.ToString();
                form1.addToCompleteTable(f1, f2, f3, f4,f5,f6);
                form1.ShowDialog();
                return;
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.ForestGreen;
            
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LimeGreen;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application apps = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = apps.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            apps.Visible = true;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Name = "Exported from GridView";

            for (int i = 1; i < table.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = table.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = table.Rows[i].Cells[j].Value.ToString();
                }
            }


            workbook.SaveAs("D:\\All Customer Data.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            apps.Quit();
        }

        private void btnprofile_MouseEnter(object sender, EventArgs e)
        {
            btnprofile.BackColor = Color.SteelBlue;
        }

        private void btnprofile_MouseLeave(object sender, EventArgs e)
        {
            btnprofile.BackColor = Color.DodgerBlue;
        }
        
        private void mainNIC_Enter(object sender, EventArgs e)
        {
            if(mainNIC.Text == "Enter Customer NIC")
            {
                mainNIC.Text = "";
                mainNIC.ForeColor = Color.Gray;
            }
        }

        private void btnprofile_Enter(object sender, EventArgs e)
        {
        }

        private void mainNIC_Leave(object sender, EventArgs e)
        {

            if (mainNIC.Text == "")
            {
                mainNIC.Text = "Enter Customer NIC";
                mainNIC.ForeColor = Color.Gray;
            }
        }

        private void textsearch_Enter(object sender, EventArgs e)
        {
            if (textsearch.Text == "Please Search by category here...")
            {
                textsearch.Text = "";
                textsearch.ForeColor = Color.Gray;
            }
        }

        private void textsearch_Leave(object sender, EventArgs e)
        {
            if (textsearch.Text == "Please Search by category here...")
            {
                textsearch.Text = "";
                textsearch.ForeColor = Color.Gray;
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            new CustomerReport().ShowDialog();
         
        }

        private void maincustomermanage_Load(object sender, EventArgs e)
        {
            Display();

            //fix rectangle curves
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
            btnprofile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnprofile.Width, btnprofile.Height, 15, 15));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 15, 15));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 15, 15));
            btnCusimport.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCusimport.Width, btnCusimport.Height, 15, 15));
            btngenerate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btngenerate.Width, btngenerate.Height, 15, 15));


            /*int f = DbCustomer.CustomerCount();
            currtxt.Text = Convert.ToString(f);

            int d = DbCustomer.nonBookedCusCount();
            noncustxt.Text = Convert.ToString(d);*/


            timer1.Start();
        }

        private void btngenerate_MouseEnter(object sender, EventArgs e)
        {
            btngenerate.BackColor = Color.DimGray;
        }

        private void btngenerate_MouseLeave(object sender, EventArgs e)
        {
            btngenerate.BackColor = Color.DarkGray;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new BackupTesting().ShowDialog();
        }
    }
}
