using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EmployeeSalary
{

    public partial class CompleteTable2 : Form
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
        public CompleteTable2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
        //this display function is used to search the details by every category 
        public void Display()
        {
            DbCustomer.DisplayAndSearch("SELECT C_Index, S_Code, NIC, Customer_Name, Vehicle_num, Com_Year, Com_Month, Com_Time, Service_count,Discount,Service_Regards FROM completetable", completetable);
            
            //automatically count the statistics whn adding

            //the discount count
            int m = DbCustomer.DiscountCount();
            distxt.Text = Convert.ToString(m);

            //the complete customer count
            int i = DbCustomer.completecount();
            currtxt.Text = Convert.ToString(i);

            //the total customer count
            int t = i - m;
            totaltxt.Text = Convert.ToString(t);
           


        }
        private void Form5_Load(object sender, EventArgs e)
        {
            
           


        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToLongTimeString();
            label8.Text = DateTime.Now.ToLongDateString();
        }

        //export the data to a excel file
        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application apps = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = apps.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            apps.Visible = true;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Name = "Exported from GridView";

            for(int i = 1; i< completetable.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = completetable.Columns[i - 1].HeaderText;
            }
            for(int i = 0; i<completetable.Rows.Count - 1;i++)
            {
                for (int j = 0;j<completetable.Columns.Count;j++)
                {
                    worksheet.Cells[i + 2, j + 1] = completetable.Rows[i].Cells[j].Value.ToString();
                }
            }


            workbook.SaveAs("D:\\Completed Services Data.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            apps.Quit();


        }

        private void CompleteTable2_Shown(object sender, EventArgs e)
        {
            Display();
        }

        //serach by each and every category and display
        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            DbCustomer.DisplayAndSearch("SELECT C_Index, S_Code, NIC, Customer_Name, Vehicle_num, Com_Year, Com_Month, Com_Time, Service_count,Discount,Service_Regards FROM completetable WHERE " + searchcombo2.Text + " LIKE'%" + textsearch2.Text + "%'", completetable);
        }

        private void completetable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //delete function in the complete table
                if (MessageBox.Show("Are you sure that you want to delete Customer record??", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                  
                    DbCustomer.DeleteService(completetable.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnExport.BackColor = Color.LightSeaGreen;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnExport.BackColor = Color.Teal;
        }

        private void btnback_MouseEnter(object sender, EventArgs e)
        {
            btnback.BackColor = Color.Goldenrod;
        }

        private void btnback_MouseLeave(object sender, EventArgs e)
        {
            btnback.BackColor = Color.Olive;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
        }

        //colouring the row that a nic is getting a discount
        private void completetable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow row in completetable.Rows)
            {
                int Service_count = Convert.ToInt32(row.Cells[9].Value);
                
                    if(Service_count == 3 )
                    {
                        row.DefaultCellStyle.BackColor = Color.IndianRed;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                
              
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
       
        //navigate to the email page
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            new SendMail().ShowDialog();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            //graphic class is for different resolutions
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        //bitmap is an object used to work with images
        Bitmap bmp;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 100, 0);
        }

        private void btnSendEmail_MouseEnter(object sender, EventArgs e)
        {
            btnSendEmail.BackColor = Color.ForestGreen;
        }

        private void btnSendEmail_MouseLeave(object sender, EventArgs e)
        {
            btnSendEmail.BackColor = Color.LimeGreen;
        }

        private void CompleteTable2_Load(object sender, EventArgs e)
        {

            //fix rectangle curves
            btnback.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnback.Width, btnback.Height, 12, 12));
            btnExport.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnExport.Width, btnExport.Height, 12, 12));
            btnSendEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSendEmail.Width, btnSendEmail.Height, 12, 12));
            btnprint.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnprint.Width, btnprint.Height, 12, 12));
            btnpiechart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnpiechart.Width, btnpiechart.Height, 12, 12));





        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnpiechart_Click(object sender, EventArgs e)
        {
            new piechart().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainDash = new MainDash();
            MainDash.Closed += (s, args) => this.Close();
            MainDash.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new BackupTesting().ShowDialog();
        }
    }
}
