using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EmployeeSalary
{
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        //display the discounted customers witin a month
        public void DisplayDisCustomers()
        {
            DbCustomer.DisplayAndSearch("SELECT NIC, Customer_Name  FROM completetable WHERE Discount = 'Yes' and Com_Month = '"+ selectMonthCombo.Text+"'", datareportview);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       /* private void CustomerReport_Load(object sender, EventArgs e)
        {
            DisplayDisCustomers();
        }*/

        //when the customer report loads the values corresponding to the month is loaded and the chart also
        private void CustomerReport_Load_1(object sender, EventArgs e)
        {
            DailyCusCountChartLoad();
            DisplayDisCustomers();


          


        }
        //the monthly customer count is counted when the month is selected in the combo box
        public void monthcuscount(string m) 
        {
            int cc = DbCustomer.MonthCustomerCount(m);
            txtccount.Text = Convert.ToString(cc);


            int b = DbCustomer.MonthnonBookedCusCount(m);
            txtnonbook.Text = Convert.ToString(b);

        }
        //the bar chart for the customer count whithin a selected month in the combo box
        public void DailyCusCountViewLoad(String m)
        {
            DailyCustomerCountChart.Series.Clear();
            DailyCustomerCountChart.Series.Add("DailyCusCount");

            int c1 = DbCustomer.graphCount(m, "01");
            int c2 = DbCustomer.graphCount(m,"02");
            int c3 = DbCustomer.graphCount(m,"03");
            int c4 = DbCustomer.graphCount(m,"04");
            int c5 = DbCustomer.graphCount(m,"05");
            int c6 = DbCustomer.graphCount(m,"06");
            int c7 = DbCustomer.graphCount(m,"07");
            int c8 = DbCustomer.graphCount(m,"08");
            int c9 = DbCustomer.graphCount(m,"09");
            int c10 = DbCustomer.graphCount(m,"10");
            int c11 = DbCustomer.graphCount(m,"11");
            int c12 = DbCustomer.graphCount(m,"12");
            int c13 = DbCustomer.graphCount(m,"13");
            int c14 = DbCustomer.graphCount(m,"14");
            int c15 = DbCustomer.graphCount(m,"15");
            int c16 = DbCustomer.graphCount(m,"16");
            int c17 = DbCustomer.graphCount(m,"17");
            int c18 = DbCustomer.graphCount(m,"18");
            int c19 = DbCustomer.graphCount(m,"19");
            int c20 = DbCustomer.graphCount(m,"20");
            int c21 = DbCustomer.graphCount(m,"21");
            int c22 = DbCustomer.graphCount(m,"22");
            int c23 = DbCustomer.graphCount(m,"23");
            int c24 = DbCustomer.graphCount(m,"24");
            int c25 = DbCustomer.graphCount(m,"25");
            int c26 = DbCustomer.graphCount(m,"26");
            int c27 = DbCustomer.graphCount(m,"27");
            int c28 = DbCustomer.graphCount(m,"28");
            int c29 = DbCustomer.graphCount(m,"29");
            int c30 = DbCustomer.graphCount(m,"30");
            int c31 = DbCustomer.graphCount(m,"31");

            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("01", c1);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("02", c2);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("03", c3);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("04", c4);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("05", c5);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("06", c6);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("07", c7);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("08", c8);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("09", c9);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("10", c10);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("11", c11);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("12", c12);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("13", c13);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("14", c14);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("15", c15);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("16", c16);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("17", c17);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("18", c18);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("19", c19);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("20", c20);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("21", c21);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("22", c22);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("23", c23);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("24", c24);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("25", c25);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("26", c26);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("27", c27);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("28", c28);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("29", c29);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("30", c30);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("31", c31);
        }

        public void DailyCusCountChartLoad()
        {/*
            DailyCustomerCountChart.Series.Clear();
            DailyCustomerCountChart.Series.Add("DailyCusCount");

            int c1 = DbCustomer.graphCount("1");
            int c2 = DbCustomer.graphCount("2");
            int c3 = DbCustomer.graphCount("3");
            int c4 = DbCustomer.graphCount("4");
            int c5 = DbCustomer.graphCount("5");
            int c6 = DbCustomer.graphCount("6");
            int c7 = DbCustomer.graphCount("7");
            int c8 = DbCustomer.graphCount("8");
            int c9 = DbCustomer.graphCount("9");
            int c10 = DbCustomer.graphCount("10");
            int c11 = DbCustomer.graphCount("11");
            int c12 = DbCustomer.graphCount("12");
            int c13 = DbCustomer.graphCount("13");
            int c14 = DbCustomer.graphCount("14");
            int c15 = DbCustomer.graphCount("15");
            int c16 = DbCustomer.graphCount("16");
            int c17 = DbCustomer.graphCount("17");
            int c18 = DbCustomer.graphCount("18");
            int c19 = DbCustomer.graphCount("19");
            int c20 = DbCustomer.graphCount("20");
            int c21 = DbCustomer.graphCount("21");
            int c22 = DbCustomer.graphCount("22");
            int c23 = DbCustomer.graphCount("23");
            int c24 = DbCustomer.graphCount("24");
            int c25 = DbCustomer.graphCount("25");
            int c26 = DbCustomer.graphCount("26");
            int c27 = DbCustomer.graphCount("27");
            int c28 = DbCustomer.graphCount("28");
            int c29 = DbCustomer.graphCount("29");
            int c30= DbCustomer.graphCount("30");
            int c31 = DbCustomer.graphCount("31");

            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("1", c1);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("2", c2);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("3", c3);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("4", c4);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("5", c5);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("6", c6);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("7", c7);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("8", c8);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("9", c9);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("10", c10);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("11", c11);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("12", c12);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("13", c13);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("14", c14);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("15", c15);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("16", c16);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("17", c17);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("18", c18);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("19", c19);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("20", c20);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("21", c21);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("22", c22);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("23", c23);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("24", c24);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("25", c25);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("26", c26);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("27", c27);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("28", c28);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("29", c29);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("30", c30);
            DailyCustomerCountChart.Series["DailyCusCount"].Points.AddXY("31", c31);*/




        }
     

        private void DailyCustomerCountChart_Click(object sender, EventArgs e)
        {

        }
        //pdf creation details
        private void btnrepprint_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                          doc.Open();

                          iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("pic1.png");
                          PNG.ScalePercent(5f);
                          PNG.Alignment = 1;
                          doc.Add(PNG);

                          Paragraph para1 = new Paragraph("ROYAL CAR SERVICE CENTER", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 30f));
                          Paragraph para21 = new Paragraph("Sri Jayawardhanapura");
                          Paragraph para22 = new Paragraph("Kotte");
                          Paragraph para2 = new Paragraph("Customer Management");
                          Paragraph para3 = new Paragraph("Month Report\n\n\n\n\n\n\n\n\n\n\n\n\n");
                          para1.Alignment = 1;
                          para2.Alignment = 1;
                          para21.Alignment = 1;
                          para22.Alignment = 1;
                          para3.Alignment = 1;
                          doc.Add(para1);
                          doc.Add(para21);
                          doc.Add(para22);
                          doc.Add(para2);
                          doc.Add(para3);

                          PdfPTable table = new PdfPTable(4);

                          PdfPCell cell = new PdfPCell(new Phrase("Daily Customer Count", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f)));
                          cell.Colspan = 4;
                          cell.HorizontalAlignment = 1;
                          table.AddCell(cell);

                        //adding cells to the table in the pdf
                         table.AddCell("Day 1      ");
                         table.AddCell(custxt1.Text);
                         table.AddCell("Day 2      ");
                         table.AddCell(custxt2.Text);

                         table.AddCell("Day 3      ");
                         table.AddCell(custxt3.Text);
                         table.AddCell("Day 4      ");
                         table.AddCell(custxt4.Text);

                         table.AddCell("Day 5      ");
                         table.AddCell(custxt5.Text);
                         table.AddCell("Day 6      ");
                         table.AddCell(custxt6.Text);

                         table.AddCell("Day 7      ");
                         table.AddCell(custxt7.Text);
                         table.AddCell("Day 8      ");
                         table.AddCell(custxt8.Text);

                         table.AddCell("Day 9      ");
                         table.AddCell(custxt9.Text);
                         table.AddCell("Day 10     ");
                         table.AddCell(custxt10.Text);

                         table.AddCell("Day 11     ");
                         table.AddCell(custxt11.Text);
                         table.AddCell("Day 12     ");
                         table.AddCell(custxt12.Text);

                         table.AddCell("Day 13      ");
                         table.AddCell(custxt13.Text);
                         table.AddCell("Day 14     ");
                         table.AddCell(custxt14.Text);

                         table.AddCell("Day 15     ");
                         table.AddCell(custxt15.Text);
                         table.AddCell("Day 16     ");
                         table.AddCell(custxt16.Text);

                         table.AddCell("Day 17     ");
                         table.AddCell(custxt17.Text);
                         table.AddCell("Day 18     ");
                         table.AddCell(custxt18.Text);

                         table.AddCell("Day 19     ");
                         table.AddCell(custxt19.Text);
                         table.AddCell("Day 20     ");
                         table.AddCell(custxt20.Text);

                         table.AddCell("Day 21     ");
                         table.AddCell(custxt21.Text);
                         table.AddCell("Day 22     ");
                         table.AddCell(custxt22.Text);

                         table.AddCell("Day 23     ");
                         table.AddCell(custxt23.Text);
                         table.AddCell("Day 24     ");
                         table.AddCell(custxt24.Text);

                         table.AddCell("Day 25     ");
                         table.AddCell(custxt25.Text);
                         table.AddCell("Day 26     ");
                         table.AddCell(custxt26.Text);

                         table.AddCell("Day 27     ");
                         table.AddCell(custxt27.Text);
                         table.AddCell("Day 28     ");
                         table.AddCell(custxt22.Text);

                         table.AddCell("Day 29     ");
                         table.AddCell(custxt29.Text);
                         table.AddCell("Day 30     ");
                         table.AddCell(custxt30.Text);

                         table.AddCell("Day 31     ");
                         table.AddCell(custxt31.Text);


                        doc.Add(table);

                        var cusChartImg = new MemoryStream();
                          DailyCustomerCountChart.SaveImage(cusChartImg, ChartImageFormat.Png);
                          iTextSharp.text.Image cusChart_image = iTextSharp.text.Image.GetInstance(cusChartImg.GetBuffer());
                          doc.Add(cusChart_image);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }

            }
        }

        //get the customer count to the calendar for the corresponding month

        public void DailyCusViewLoad(String m)
        {
            custxt1.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("01",m));
            custxt2.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("02", m));
            custxt3.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("03", m));
            custxt4.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("04", m));
            custxt5.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("05", m));
            custxt6.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("06", m));
            custxt7.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("07", m));
            custxt8.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("08", m));
            custxt9.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("09", m));
            custxt10.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("10",m));
            custxt11.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("11", m));
            custxt12.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("12", m));
            custxt13.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("13", m));
            custxt14.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("14", m));
            custxt15.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("15", m));
            custxt16.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("16", m));
            custxt17.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("17", m));
            custxt17.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("17", m));
            custxt18.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("18", m));
            custxt19.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("19", m));
            custxt20.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("20", m));
            custxt21.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("21", m));
            custxt22.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("22", m));
            custxt23.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("23", m));
            custxt24.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("24", m));
            custxt25.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("25", m));
            custxt26.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("26", m));
            custxt27.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("27", m));
            custxt28.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("28", m));
            custxt29.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("29", m));
            custxt30.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("30", m));
            custxt31.Text = Convert.ToString(DbCustomer.getCustomerCountForMonth("31", m));
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if(selectMonthCombo.Text == string.Empty)
            {
                MessageBox.Show("Please select a month");
                return;
            }

            DailyCusCountViewLoad(selectMonthCombo.Text);
            DailyCusViewLoad(selectMonthCombo.Text);
            monthcuscount(selectMonthCombo.Text);
           





        }

        private void selectMonthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
