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
    public partial class CurrentStock : Form
    {
        
        //fix rectangle to curve
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

        AddStock form;
        ListForm form1;


        public CurrentStock()
        {
            InitializeComponent();
            form = new AddStock(this);
            form1 = new ListForm(this);
        }

        public void Display()
        {
            //display details
            StockDB.DisplayAndSearch("SELECT Item_Id,Item_Name, Date, Quantity, Unit_Price, Min_quantity FROM currentstock_table", CurrentStkTblgrid);
            loadDatagridDetails();


        }


        private void CurrentStock_Load(object sender, EventArgs e)
        {

            //maximize to full screen
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            //get the date and time
            timerCurrent.Start();

            //buttons' border changing to curve
            addNewBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addNewBtn.Width, addNewBtn.Height, 15, 15));
            viewListbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addNewBtn.Width, addNewBtn.Height, 15, 15));
            GnrateReportStkbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addNewBtn.Width, addNewBtn.Height, 15, 15));
        }


        private void addNewBtn_Click(object sender, EventArgs e)
        {
            //show  addStock as pop up
           new AddStock(this).ShowDialog();
           form.Clear();

        }

        

        private void viewListbtn_Click(object sender, EventArgs e)
        {
            //get new items needs to by table as pop up
            new ListRequired().ShowDialog();
        }

        private void timerCurrent_Tick(object sender, EventArgs e)
        {
            //get date and time
            timeCurrntlbl.Text = DateTime.Now.ToLongTimeString();
            dateCurrentlbl.Text = DateTime.Now.ToLongDateString();
        }

        private void closeCurrentbtn_Click(object sender, EventArgs e)
        {
            //close button
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CurrentStock_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void SearchCurrentbtn_TextChanged(object sender, EventArgs e)
        {
            //Search by item name
            StockDB.DisplayAndSearch("SELECT Item_Id,Item_Name, Date, Quantity, Unit_Price, Min_quantity FROM currentstock_table WHERE Item_Name LIKE '%" + SearchCurrentbtn.Text+ "%'", CurrentStkTblgrid);
            loadDatagridDetails();
        }

        private void CurrentStkTblgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(Convert.ToString(e.ColumnIndex));
            if (e.ColumnIndex == 1)
            {
                //Edit
                form.Clear();
                /*MessageBox.Show(CurrentStkTblgrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                Application.Exit();*/

                form.id= CurrentStkTblgrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.name= CurrentStkTblgrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.date= CurrentStkTblgrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.quantity= CurrentStkTblgrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.unit_price = CurrentStkTblgrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.total_price = CurrentStkTblgrid.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                
                return;
            }
            if (e.ColumnIndex == 2)
            {
                //Delete
                if(MessageBox.Show("Do you want to delete this record?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.Yes)
                {
                    
                    StockDB.DeleteCurrentStockDB(CurrentStkTblgrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
                return;
            }
            if (e.ColumnIndex == 0)
            {
                //add to list
                form1.f1 = CurrentStkTblgrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                form1.f2 = CurrentStkTblgrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                form1.f3 = CurrentStkTblgrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                form1.ShowDialog();
            }
        }

        private void SearchCurrentbtn_Enter(object sender, EventArgs e)
        {
            //Search by item name(placeholder)
            if (SearchCurrentbtn.Text == "Search By Item Name")
            {
                SearchCurrentbtn.Text = "";
                SearchCurrentbtn.ForeColor = Color.Black;
            }
        }

        

        private void CurrentStkTblgrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //min quantity
            if(e.ColumnIndex == 6)
            {
                if (Convert.ToInt32(CurrentStkTblgrid.Rows[e.RowIndex].Cells[6].Value.ToString()) <= (Convert.ToInt32(CurrentStkTblgrid.Rows[e.RowIndex].Cells[8].Value.ToString()) + Convert.ToInt32(CurrentStkTblgrid.Rows[e.RowIndex].Cells[8].Value.ToString()) / 4))
                    e.CellStyle.BackColor = Color.LightBlue;

                if (Convert.ToInt32(CurrentStkTblgrid.Rows[e.RowIndex].Cells[6].Value.ToString()) <= Convert.ToInt32(CurrentStkTblgrid.Rows[e.RowIndex].Cells[8].Value.ToString()))
                e.CellStyle.BackColor = Color.Pink;
            }
            
        }

        private void homeCurrentbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GnrateReportStkbtn_Click(object sender, EventArgs e)
        {
            //show report form as pop up
            new ReportStkForm().ShowDialog();


        }

        public void loadDatagridDetails()
        {
            //chart
            Color _color1 = Color.LightGreen;
            Color _color2 = Color.PaleVioletRed;   //BurlyWood

            seriesColor1.BackColor = _color1;
            seriesColor2.BackColor = _color2;

            CurrentStockChart.Series.Clear();
            CurrentStockChart.Series.Add("Current Quantity").Color = _color1;
            CurrentStockChart.Series.Add("Minimum Quantity").Color = _color2;

            //get the count of raws
            int rowCount = CurrentStkTblgrid.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                CurrentStockChart.Series["Current Quantity"].Points.AddXY(CurrentStkTblgrid.Rows[i].Cells[4].Value.ToString(), Convert.ToString(CurrentStkTblgrid.Rows[i].Cells[6].Value.ToString()));

                CurrentStockChart.Series["Minimum Quantity"].Points.AddXY(CurrentStkTblgrid.Rows[i].Cells[4].Value.ToString(), Convert.ToString(CurrentStkTblgrid.Rows[i].Cells[8].Value.ToString()));
            }
        }

        private void settingsCurrentbtn_Click(object sender, EventArgs e)
        {
            new BackupTesting().ShowDialog();
        }
    }
}
