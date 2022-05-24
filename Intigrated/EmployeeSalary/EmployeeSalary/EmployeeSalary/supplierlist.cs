using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Suppliermanage
{
    public partial class supplierlist : Form
    {
        Supplierform form;


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
        public supplierlist()
        {
            InitializeComponent();
            form = new Supplierform(this);
        }

        public void Display()
        {
            dbsupplier.DisplaySupplier("SELECT sup_id, companyname, address, country, contactnumber, email, Item_Id, itemtype, description, date FROM suppliermanage", dataGridView1);
            loadChartDetails();
        }
        private void suppliermanage_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


            buttonadd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonadd.Width, buttonadd.Height, 30, 30));

            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
            label1.Text = DateTime.Now.ToLongDateString();

          

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sup1_Click(object sender, EventArgs e)
        {

        }




        private void textBox2_TextChanged(object sender, EventArgs e)

        {
            //dbsupplier.DisplaySupplier("SELECT sup_id, companyname, address, country, contactnumber, email, paymenttype, itemtype, description, date FROM suppliermanage WHERE itemtype LIKE'%" + textsearch.Text + "%'", dataGridView1);
            dbsupplier.DisplaySupplier("SELECT sup_id, companyname,address,country,contactnumber,email,Item_Id,itemtype,description,date FROM suppliermanage WHERE " + comboBox1.Text + " LIKE'%" + textsearch.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }



        private void buttonadd_Click(object sender, EventArgs e)
        {
            form.clear();
            new Supplierform(this).ShowDialog();
        }

        private void buttonview_Click(object sender, EventArgs e)
        {
            new Supplierprofile().ShowDialog();
        }

        private void supplierlist_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                //edit button click
                form.clear();
                form.sup_id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.companyname = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.address = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.country = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.contactnumber = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.email = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.Item_Id = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.itemtype = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.description = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.date = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;


                //edit

            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete Supplier Record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    dbsupplier.DeleteSupplier(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //dbsupplier.UpdateSupplire();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            new Form1sup().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new supplierlist().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new reportgrid().ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(objBmp, -237, 200);

            e.Graphics.DrawString(sup1.Text, new Font("century gothic", 24, FontStyle.Regular), Brushes.Blue, new Point(200, 60));

        }

        private void button9_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dbsupplier.DisplaySupplier("SELECT sup_id, companyname, address, country, contactnumber, email, paymenttype, itemtype, description, date FROM suppliermanage WHERE date LIKE'%" + textsearch.Text + "%'", dataGridView1);
        }

        private void textsearch_Enter(object sender, EventArgs e)
        {
            if (textsearch.Text == "Search by ")
            {
                textsearch.Text = "";
                textsearch.ForeColor = Color.Black;
            }
        }

        private void textsearch_Leave(object sender, EventArgs e)
        {
            if (textsearch.Text == "")
            {
                textsearch.Text = "Search by";
                textsearch.ForeColor = Color.DarkGray;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Supplierprofile sp = new Supplierprofile();

            sp.rtbBody.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sp.textBox4.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            sp.textBox5.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            sp.textBox6.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            sp.textBox2.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            sp.comboBox2.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            sp.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            sp.textBox9.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            sp.textBox10.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            sp.ShowDialog();
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            new reportgrid().ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; SslMode = none");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Order_Id, Item_Id, Item_Name, Date, Req_Quantity FROM csm.liststock_table", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "liststock_table");
                dataGridView2.DataSource = ds.Tables["liststock_table"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supplierlist_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1sup sp = new Form1sup();

            sp.rtbBody.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
                
            /*sp.textBox4.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            sp.textBox5.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            sp.textBox6.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            sp.textBox2.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            sp.comboBox2.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            sp.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            sp.textBox9.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            sp.textBox10.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();*/
            sp.ShowDialog();
        }

        public void loadChartDetails()
        {
            int lubCount = 0;
            int SpareCount = 0;
            int CarBodyCount = 0;
            int PaintCount = 0;
            int AudVidCount = 0;

            int rowCount = dataGridView1.RowCount;


            for(int i = 0; i < rowCount; i++)
            {
                String iType = dataGridView1.Rows[i].Cells[9].Value.ToString();
                if (iType == "Lubricant")
                    lubCount++;
                else if (iType == "Spare Parts")
                    SpareCount++;
                else if (iType == "Car body")
                    CarBodyCount++;
                else if (iType == "Paints")
                    PaintCount++;
                else
                    AudVidCount++;
            }

            itemTypeChart.Series.Clear();
            itemTypeChart.Series.Add("pMenthodTot");
            itemTypeChart.Series["pMenthodTot"].ChartType = SeriesChartType.Doughnut;

            itemTypeChart.Series["pMenthodTot"].Points.AddXY("Lubricants", lubCount);
            itemTypeChart.Series["pMenthodTot"].Points.AddXY("Spare Parts", SpareCount);
            itemTypeChart.Series["pMenthodTot"].Points.AddXY("Car Body", CarBodyCount);
            itemTypeChart.Series["pMenthodTot"].Points.AddXY("Paints", PaintCount);
            itemTypeChart.Series["pMenthodTot"].Points.AddXY("Audio video", AudVidCount);
        }

        private void button11_Click(object sender, EventArgs e)
        {
           //MessageBox.Show(dataGridView1.col)
           MessageBox.Show(dataGridView1.Rows[0].Cells[9].Value.ToString());

        }
    }
    
}









