using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EmployeeSalary
{   
    public partial class BookingReport : Form
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

        public BookingReport()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }
        //Month button
        private void button4_Click(object sender, EventArgs e)
        {
            //itplogo
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("projectIcon.png");
                        PNG.ScalePercent(5f);
                        PNG.Alignment = 1;
                        doc.Add(PNG);

                        Paragraph para1 = new Paragraph("ROYAL CAR SERVICE CENTER", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 30f));
                        Paragraph para21 = new Paragraph("Sri Jayawardhanapura", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f));
                        Paragraph para22 = new Paragraph("Kotte", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f));
                        Paragraph para2 = new Paragraph("EmployeeSalary Management");
                        Paragraph para3 = new Paragraph("Monthly Report\n\n\n\n\n\n\n\n\n\n\n\n\n");
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

                        PdfPCell cell = new PdfPCell(new Phrase("Daily EmployeeSalary Count", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f)));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = 1;
                        table.AddCell(cell);

                        table.AddCell("Day 1 ");
                        table.AddCell(bktxt01.Text);
                        table.AddCell("Day 2 ");
                        table.AddCell(bktxt02.Text);

                        table.AddCell("Day 3 ");
                        table.AddCell(bktxt03.Text);
                        table.AddCell("Day 4 ");
                        table.AddCell(bktxt04.Text);

                        table.AddCell("Day 5 ");
                        table.AddCell(bktxt05.Text);
                        table.AddCell("Day 6 ");
                        table.AddCell(bktxt06.Text);

                        table.AddCell("Day 7 ");
                        table.AddCell(bktxt07.Text);
                        table.AddCell("Day 8 ");
                        table.AddCell(bktxt08.Text);

                        table.AddCell("Day 9 ");
                        table.AddCell(bktxt09.Text);
                        table.AddCell("Day 10 ");
                        table.AddCell(bktxt10.Text);

                        table.AddCell("Day 11 ");
                        table.AddCell(bktxt11.Text);
                        table.AddCell("Day 12 ");
                        table.AddCell(bktxt12.Text);

                        table.AddCell("Day 13 ");
                        table.AddCell(bktxt13.Text);
                        table.AddCell("Day 14 ");
                        table.AddCell(bktxt14.Text);

                        table.AddCell("Day 15 ");
                        table.AddCell(bktxt15.Text);
                        table.AddCell("Day 16 ");
                        table.AddCell(bktxt16.Text);

                        table.AddCell("Day 17 ");
                        table.AddCell(bktxt17.Text);
                        table.AddCell("Day 18 ");
                        table.AddCell(bktxt18.Text);

                        table.AddCell("Day 19 ");
                        table.AddCell(bktxt19.Text);
                        table.AddCell("Day 20 ");
                        table.AddCell(bktxt20.Text);

                        table.AddCell("Day 21 ");
                        table.AddCell(bktxt21.Text);
                        table.AddCell("Day 22 ");
                        table.AddCell(bktxt22.Text);

                        table.AddCell("Day 23 ");
                        table.AddCell(bktxt23.Text);
                        table.AddCell("Day 24 ");
                        table.AddCell(bktxt24.Text);

                        table.AddCell("Day 25 ");
                        table.AddCell(bktxt25.Text);
                        table.AddCell("Day 26 ");
                        table.AddCell(bktxt26.Text);

                        table.AddCell("Day 27 ");
                        table.AddCell(bktxt27.Text);
                        table.AddCell("Day 28 ");
                        table.AddCell(bktxt28.Text);

                        table.AddCell("Day 29 ");
                        table.AddCell(bktxt29.Text);
                        table.AddCell("Day 30 ");
                        table.AddCell(bktxt30.Text);

                        table.AddCell("Day 31 ");
                        table.AddCell(bktxt31.Text);
                        table.AddCell("       ");
                        table.AddCell("    ");

                        doc.Add(table);
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

        private void BookingReport_Load(object sender, EventArgs e)

        {
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 10, 10));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 15, 15));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 15, 15));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 15, 15));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 15, 15));
            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width, panel9.Height, 15, 15));
            panel10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel10.Width, panel10.Height, 15, 15));
            panel11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel11.Width, panel11.Height, 15, 15));
            panel12.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel12.Width, panel12.Height, 15, 15));
            panel13.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel13.Width, panel13.Height, 15, 15));
            panel14.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel14.Width, panel14.Height, 15, 15));
            panel15.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel15.Width, panel15.Height, 15, 15));
            panel16.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel16.Width, panel16.Height, 15, 15));
            panel17.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel17.Width, panel17.Height, 15, 15));
            panel18.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel18.Width, panel18.Height, 15, 15));
            panel19.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel19.Width, panel19.Height, 15, 15));
            panel20.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel20.Width, panel20.Height, 15, 15));
            panel21.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel21.Width, panel21.Height, 15, 15));
            panel22.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel22.Width, panel22.Height, 15, 15));
            panel23.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel23.Width, panel23.Height, 15, 15));
            panel24.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel24.Width, panel24.Height, 15, 15));
            panel25.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel25.Width, panel25.Height, 15, 15));
            panel26.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel26.Width, panel26.Height, 15, 15));
            panel27.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel27.Width, panel27.Height, 15, 15));
            panel28.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel28.Width, panel28.Height, 15, 15));
            panel29.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel29.Width, panel29.Height, 15, 15));
            panel30.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel30.Width, panel30.Height, 15, 15));
            panel31.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel31.Width, panel31.Height, 15, 15));
            panel32.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel32.Width, panel32.Height, 15, 15));
            panel33.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel33.Width, panel33.Height, 15, 15));
            panel34.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel34.Width, panel34.Height, 15, 15));
            panel35.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel35.Width, panel35.Height, 15, 15));
            panel36.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel36.Width, panel36.Height, 15, 15));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 15, 15));
            
        }
        public void loadCalenderView(String month)
        {
            bktxt01.Text = Convert.ToString(bookingtb.getBookingCountForMonth("1", month));
            bktxt02.Text = Convert.ToString(bookingtb.getBookingCountForMonth("2", month));
            bktxt03.Text = Convert.ToString(bookingtb.getBookingCountForMonth("3", month));
            bktxt04.Text = Convert.ToString(bookingtb.getBookingCountForMonth("4", month));
            bktxt05.Text = Convert.ToString(bookingtb.getBookingCountForMonth("5", month));
            bktxt06.Text = Convert.ToString(bookingtb.getBookingCountForMonth("6", month));
            bktxt07.Text = Convert.ToString(bookingtb.getBookingCountForMonth("7", month));
            bktxt08.Text = Convert.ToString(bookingtb.getBookingCountForMonth("8", month));
            bktxt09.Text = Convert.ToString(bookingtb.getBookingCountForMonth("9", month));
            bktxt10.Text = Convert.ToString(bookingtb.getBookingCountForMonth("10", month));
            bktxt11.Text = Convert.ToString(bookingtb.getBookingCountForMonth("11", month));
            bktxt12.Text = Convert.ToString(bookingtb.getBookingCountForMonth("12", month));
            bktxt13.Text = Convert.ToString(bookingtb.getBookingCountForMonth("13", month));
            bktxt14.Text = Convert.ToString(bookingtb.getBookingCountForMonth("14", month));
            bktxt15.Text = Convert.ToString(bookingtb.getBookingCountForMonth("15", month));
            bktxt16.Text = Convert.ToString(bookingtb.getBookingCountForMonth("16", month));
            bktxt17.Text = Convert.ToString(bookingtb.getBookingCountForMonth("17", month));
            bktxt18.Text = Convert.ToString(bookingtb.getBookingCountForMonth("18", month));
            bktxt19.Text = Convert.ToString(bookingtb.getBookingCountForMonth("19", month));
            bktxt20.Text = Convert.ToString(bookingtb.getBookingCountForMonth("20", month));
            bktxt21.Text = Convert.ToString(bookingtb.getBookingCountForMonth("21", month));
            bktxt22.Text = Convert.ToString(bookingtb.getBookingCountForMonth("22", month));
            bktxt23.Text = Convert.ToString(bookingtb.getBookingCountForMonth("23", month));
            bktxt24.Text = Convert.ToString(bookingtb.getBookingCountForMonth("24", month));
            bktxt25.Text = Convert.ToString(bookingtb.getBookingCountForMonth("25", month));
            bktxt26.Text = Convert.ToString(bookingtb.getBookingCountForMonth("26", month));
            bktxt27.Text = Convert.ToString(bookingtb.getBookingCountForMonth("27", month));
            bktxt28.Text = Convert.ToString(bookingtb.getBookingCountForMonth("28", month));
            bktxt29.Text = Convert.ToString(bookingtb.getBookingCountForMonth("29", month));
            bktxt30.Text = Convert.ToString(bookingtb.getBookingCountForMonth("30", month));
            bktxt31.Text = Convert.ToString(bookingtb.getBookingCountForMonth("31", month));
        }

        

        private void loadCalenderViewBtn1_Click(object sender, EventArgs e)
        {
            if (calenderMonthCombo.Text == string.Empty)
            {
                MessageBox.Show("Select a month");
                return;
            }
            loadCalenderView(calenderMonthCombo.Text);
            LoadChart(calenderMonthCombo.Text);
            TOTALBKtxt.Text = bookingtb.getTotBooking(calenderMonthCombo.Text);
        }

        public void LoadChart(String m)
        {
            string s1 = bookingtb.getChartDetails("booking type 1", m);
            string s2 = bookingtb.getChartDetails("booking type 2", m);
            string s3 = bookingtb.getChartDetails("booking type 3", m);
            string s4 = bookingtb.getChartDetails("booking type 4", m);
            string s5 = bookingtb.getChartDetails("booking type 5", m);
            string s6 = bookingtb.getChartDetails("booking type 6", m);
            string s7 = bookingtb.getChartDetails("booking type 7", m);
            string s8 = bookingtb.getChartDetails("booking type 8", m);

            BookingTypeChart.Series.Clear();
            BookingTypeChart.Series.Add("Booking Type");
            BookingTypeChart.Series["Booking Type"].ChartType = SeriesChartType.Doughnut;

            BookingTypeChart.Series["Booking Type"].Points.AddXY("Type 1", s1);
            BookingTypeChart.Series["Booking Type"].Points.AddXY("Type 2", s2);
            BookingTypeChart.Series["Booking Type"].Points.AddXY("Type 3", s3);
            BookingTypeChart.Series["Booking Type"].Points.AddXY("Type 4", s4);
            BookingTypeChart.Series["Booking Type"].Points.AddXY("Type 5", s5);
            BookingTypeChart.Series["Booking Type"].Points.AddXY("Type 6", s6);
            BookingTypeChart.Series["Booking Type"].Points.AddXY("Type 7", s7);
            BookingTypeChart.Series["Booking Type"].Points.AddXY("Type 8", s8);
        }
        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt01_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt02_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt03_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt04_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt05_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt06_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt07_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt08_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt09_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt10_Click(object sender, EventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt12_Click(object sender, EventArgs e)
        {

        }

        private void bktxt13_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt14_Click(object sender, EventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt15_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void bktxt18_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt19_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt20_Click(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void bktxt21_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void bktxt22_Click(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void bktxt11_Click(object sender, EventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt16_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void bktxt17_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void TOTALBKtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bktxt23_Click(object sender, EventArgs e)
        {

        }
    }
}
