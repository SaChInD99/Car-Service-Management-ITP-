using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace EmployeeSalary
{

    public partial class IncomeFinanceMonthlyReport : Form
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

        Color _colorR = Color.Pink;
        Color _colorG = Color.LightGreen;

        int dailyTrget = 0;
        int dailyTrgetIncm = 0;
        int tPrice = 0;
        public IncomeFinanceMonthlyReport()
        {
            InitializeComponent();
        }

        private void IncomeFinanceMonthlyReport_Load(object sender, EventArgs e)
        {
            int daySize = 15;
            //ReportRefresh.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ReportRefresh.Width, ReportRefresh.Height, 12, 12));
            panel0.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel0.Width, panel0.Height, daySize, daySize));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, daySize, daySize));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, daySize, daySize));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, daySize, daySize));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, daySize, daySize));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, daySize, daySize));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, daySize, daySize));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, daySize, daySize));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, daySize, daySize));
            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width, panel9.Height, daySize, daySize));
            panel10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel10.Width, panel10.Height, daySize, daySize));
            panel11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel11.Width, panel11.Height, daySize, daySize));
            panel12.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel12.Width, panel12.Height, daySize, daySize));
            panel13.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel13.Width, panel13.Height, daySize, daySize));
            panel14.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel14.Width, panel14.Height, daySize, daySize));
            panel15.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel15.Width, panel15.Height, daySize, daySize));
            panel16.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel16.Width, panel16.Height, daySize, daySize));
            panel17.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel17.Width, panel17.Height, daySize, daySize));
            panel18.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel18.Width, panel18.Height, daySize, daySize));
            panel19.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel19.Width, panel19.Height, daySize, daySize));
            panel20.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel20.Width, panel20.Height, daySize, daySize));
            panel21.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel21.Width, panel21.Height, daySize, daySize));
            panel22.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel22.Width, panel22.Height, daySize, daySize));
            panel23.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel23.Width, panel23.Height, daySize, daySize));
            panel24.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel24.Width, panel24.Height, daySize, daySize));
            panel25.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel25.Width, panel25.Height, daySize, daySize));
            panel26.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel26.Width, panel26.Height, daySize, daySize));
            panel27.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel27.Width, panel27.Height, daySize, daySize));
            panel28.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel28.Width, panel28.Height, daySize, daySize));
            panel29.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel29.Width, panel29.Height, daySize, daySize));
            panel30.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel30.Width, panel30.Height, daySize, daySize));

            incmPDF.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, incmPDF.Width, incmPDF.Height, 10, 10));
            printMonthlyReport.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, printMonthlyReport.Width, printMonthlyReport.Height, 10, 10));
            loadReportIntoForm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loadReportIntoForm.Width, loadReportIntoForm.Height, 12, 12));


        }

        public void loadMotnhlyDeialsToForm()
        {

            loadDailyIncomeChart();
            reportMonthlyTot.Text = Convert.ToString(IncomeDB.getThisMonthTotalIncome(calviewcombomonth.Text, calviewcomboyear.Text));

        }

        private void printIFMreportDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(btmp, 0, 0);
        }

        Bitmap btmp;

        private void printMonthlyReport_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            btmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(btmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printIFMreportPreview.ShowDialog();
        }

        public void loadDailyIncomeChart()
        {
            montlyIncmChart.Series.Clear();
            montlyIncmChart.Series.Add("daily");

            int d1 = Convert.ToInt32(dPrice1.Text);
            int d2 = Convert.ToInt32(dPrice2.Text);
            int d3 = Convert.ToInt32(dPrice3.Text);
            int d4 = Convert.ToInt32(dPrice4.Text);
            int d5 = Convert.ToInt32(dPrice5.Text);
            int d6 = Convert.ToInt32(dPrice6.Text);
            int d7 = Convert.ToInt32(dPrice7.Text);
            int d8 = Convert.ToInt32(dPrice8.Text);
            int d9 = Convert.ToInt32(dPrice9.Text);
            int d10 = Convert.ToInt32(dPrice10.Text);
            int d11 = Convert.ToInt32(dPrice11.Text);
            int d12 = Convert.ToInt32(dPrice12.Text);
            int d13 = Convert.ToInt32(dPrice13.Text);
            int d14 = Convert.ToInt32(dPrice14.Text);
            int d15 = Convert.ToInt32(dPrice15.Text);
            int d16 = Convert.ToInt32(dPrice16.Text);
            int d17 = Convert.ToInt32(dPrice17.Text);
            int d18 = Convert.ToInt32(dPrice18.Text);
            int d19 = Convert.ToInt32(dPrice19.Text);
            int d20 = Convert.ToInt32(dPrice20.Text);
            int d21 = Convert.ToInt32(dPrice21.Text);
            int d22 = Convert.ToInt32(dPrice22.Text);
            int d23 = Convert.ToInt32(dPrice23.Text);
            int d24 = Convert.ToInt32(dPrice24.Text);
            int d25 = Convert.ToInt32(dPrice25.Text);
            int d26 = Convert.ToInt32(dPrice26.Text);
            int d27 = Convert.ToInt32(dPrice27.Text);
            int d28 = Convert.ToInt32(dPrice28.Text);
            int d29 = Convert.ToInt32(dPrice29.Text);
            int d30 = Convert.ToInt32(dPrice30.Text);
            int d31 = Convert.ToInt32(dPrice31.Text);

            tfailPriceTxt.BackColor = _colorR;
            tachievedColor.BackColor = _colorG;
            dailyIncmTrgetTxt.Text = "Daily Income Target = " + Convert.ToString(dailyTrget);

            montlyIncmChart.Series["daily"].Points.AddXY("1", d1);
            if (dailyTrget > 0 && dailyTrget >= d1)
            {
                montlyIncmChart.Series["daily"].Points[0].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d1)
            {
                montlyIncmChart.Series["daily"].Points[0].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("2", d2);
            if (dailyTrget > 0 && dailyTrget >= d2)
            {
                montlyIncmChart.Series["daily"].Points[1].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d2)
            {
                montlyIncmChart.Series["daily"].Points[1].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("3", d3);
            if (dailyTrget > 0 && dailyTrget >= d3)
            {
                montlyIncmChart.Series["daily"].Points[2].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d3)
            {
                montlyIncmChart.Series["daily"].Points[2].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("4", d4);
            if (dailyTrget > 0 && dailyTrget >= d4)
            {
                montlyIncmChart.Series["daily"].Points[3].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d4)
            {
                montlyIncmChart.Series["daily"].Points[3].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("5", d5);
            if (dailyTrget > 0 && dailyTrget >= d5)
            {
                montlyIncmChart.Series["daily"].Points[4].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d5)
            {
                montlyIncmChart.Series["daily"].Points[4].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("6", d6);
            if (dailyTrget > 0 && dailyTrget >= d6)
            {
                montlyIncmChart.Series["daily"].Points[5].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d6)
            {
                montlyIncmChart.Series["daily"].Points[5].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("7", d7);
            if (dailyTrget > 0 && dailyTrget >= d7)
            {
                montlyIncmChart.Series["daily"].Points[6].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d7)
            {
                montlyIncmChart.Series["daily"].Points[6].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("8", d8);
            if (dailyTrget > 0 && dailyTrget >= d8)
            {
                montlyIncmChart.Series["daily"].Points[7].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d8)
            {
                montlyIncmChart.Series["daily"].Points[7].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("9", d9);
            if (dailyTrget > 0 && dailyTrget >= d9)
            {
                montlyIncmChart.Series["daily"].Points[8].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d9)
            {
                montlyIncmChart.Series["daily"].Points[8].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("10", d10);
            if (dailyTrget > 0 && dailyTrget >= d10)
            {
                montlyIncmChart.Series["daily"].Points[9].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d10)
            {
                montlyIncmChart.Series["daily"].Points[9].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("11", d11);
            if (dailyTrget > 0 && dailyTrget >= d11)
            {
                montlyIncmChart.Series["daily"].Points[10].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d11)
            {
                montlyIncmChart.Series["daily"].Points[10].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("12", d12);
            if (dailyTrget > 0 && dailyTrget >= d12)
            {
                montlyIncmChart.Series["daily"].Points[11].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d12)
            {
                montlyIncmChart.Series["daily"].Points[11].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("13", d13);
            if (dailyTrget > 0 && dailyTrget >= d13)
            {
                montlyIncmChart.Series["daily"].Points[12].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d13)
            {
                montlyIncmChart.Series["daily"].Points[12].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("14", d14);
            if (dailyTrget > 0 && dailyTrget >= d14)
            {
                montlyIncmChart.Series["daily"].Points[13].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d14)
            {
                montlyIncmChart.Series["daily"].Points[13].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("15", d15);
            if (dailyTrget > 0 && dailyTrget >= d15)
            {
                montlyIncmChart.Series["daily"].Points[14].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d15)
            {
                montlyIncmChart.Series["daily"].Points[14].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("16", d16);
            if (dailyTrget > 0 && dailyTrget >= d16)
            {
                montlyIncmChart.Series["daily"].Points[15].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d16)
            {
                montlyIncmChart.Series["daily"].Points[15].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("17", d17);
            if (dailyTrget > 0 && dailyTrget >= d17)
            {
                montlyIncmChart.Series["daily"].Points[16].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d17)
            {
                montlyIncmChart.Series["daily"].Points[16].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("18", d18);
            if (dailyTrget > 0 && dailyTrget >= d18)
            {
                montlyIncmChart.Series["daily"].Points[17].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d18)
            {
                montlyIncmChart.Series["daily"].Points[17].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("19", d19);
            if (dailyTrget > 0 && dailyTrget >= d19)
            {
                montlyIncmChart.Series["daily"].Points[18].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d19)
            {
                montlyIncmChart.Series["daily"].Points[18].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("20", d20);
            if (dailyTrget > 0 && dailyTrget >= d20)
            {
                montlyIncmChart.Series["daily"].Points[19].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d20)
            {
                montlyIncmChart.Series["daily"].Points[19].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("21", d21);
            if (dailyTrget > 0 && dailyTrget >= d21)
            {
                montlyIncmChart.Series["daily"].Points[20].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d21)
            {
                montlyIncmChart.Series["daily"].Points[20].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("22", d22);
            if (dailyTrget > 0 && dailyTrget >= d22)
            {
                montlyIncmChart.Series["daily"].Points[21].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d22)
            {
                montlyIncmChart.Series["daily"].Points[21].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("23", d23);
            if (dailyTrget > 0 && dailyTrget >= d23)
            {
                montlyIncmChart.Series["daily"].Points[22].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d23)
            {
                montlyIncmChart.Series["daily"].Points[22].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("24", d24);
            if (dailyTrget > 0 && dailyTrget >= d24)
            {
                montlyIncmChart.Series["daily"].Points[23].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d24)
            {
                montlyIncmChart.Series["daily"].Points[23].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("25", d25);
            if (dailyTrget > 0 && dailyTrget >= d25)
            {
                montlyIncmChart.Series["daily"].Points[24].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d25)
            {
                montlyIncmChart.Series["daily"].Points[24].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("26", d26);
            if (dailyTrget > 0 && dailyTrget >= d26)
            {
                montlyIncmChart.Series["daily"].Points[25].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d26)
            {
                montlyIncmChart.Series["daily"].Points[25].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("27", d27);
            if (dailyTrget > 0 && dailyTrget >= d27)
            {
                montlyIncmChart.Series["daily"].Points[26].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d27)
            {
                montlyIncmChart.Series["daily"].Points[26].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("28", d28);
            if (dailyTrget > 0 && dailyTrget >= d28)
            {
                montlyIncmChart.Series["daily"].Points[27].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d28)
            {
                montlyIncmChart.Series["daily"].Points[27].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("29", d29);
            if (dailyTrget > 0 && dailyTrget >= d29)
            {
                montlyIncmChart.Series["daily"].Points[28].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d29)
            {
                montlyIncmChart.Series["daily"].Points[28].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("30", d30);
            if (dailyTrget > 0 && dailyTrget >= d30)
            {
                montlyIncmChart.Series["daily"].Points[29].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d30)
            {
                montlyIncmChart.Series["daily"].Points[29].Color = _colorG;
            }

            montlyIncmChart.Series["daily"].Points.AddXY("31", d31);
            if (dailyTrget > 0 && dailyTrget >= d31)
            {
                montlyIncmChart.Series["daily"].Points[30].Color = _colorR;
            }
            if (dailyTrget > 0 && dailyTrget < d31)
            {
                montlyIncmChart.Series["daily"].Points[30].Color = _colorG;
            }

        }

        private void ReportRefresh_Click(object sender, EventArgs e)
        {


        }

        private void incmPDF_Click(object sender, EventArgs e)
        {
            if (monthlyReportHeading.Text == string.Empty)
            {
                MessageBox.Show("Please load the details first");
                return;
            }
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
                        Paragraph para2 = new Paragraph("Income Finance Management");
                        Paragraph para3 = new Paragraph(monthlyReportHeading.Text + "\n\n\n\n\n\n\n\n\n\n\n\n\n");
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

                        PdfPCell cell = new PdfPCell(new Phrase("Daily total income", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f)));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = 1;
                        table.AddCell(cell);

                        table.AddCell("Day 1      ");
                        table.AddCell(dPrice1.Text);
                        table.AddCell("Day 2      ");
                        table.AddCell(dPrice2.Text);

                        table.AddCell("Day 3      ");
                        table.AddCell(dPrice3.Text);
                        table.AddCell("Day 4      ");
                        table.AddCell(dPrice4.Text);

                        table.AddCell("Day 5      ");
                        table.AddCell(dPrice5.Text);
                        table.AddCell("Day 6      ");
                        table.AddCell(dPrice6.Text);

                        table.AddCell("Day 7      ");
                        table.AddCell(dPrice7.Text);
                        table.AddCell("Day 8      ");
                        table.AddCell(dPrice8.Text);

                        table.AddCell("Day 9      ");
                        table.AddCell(dPrice9.Text);
                        table.AddCell("Day 10     ");
                        table.AddCell(dPrice10.Text);

                        table.AddCell("Day 11     ");
                        table.AddCell(dPrice11.Text);
                        table.AddCell("Day 12     ");
                        table.AddCell(dPrice12.Text);

                        table.AddCell("Day 13      ");
                        table.AddCell(dPrice13.Text);
                        table.AddCell("Day 14     ");
                        table.AddCell(dPrice14.Text);

                        table.AddCell("Day 15     ");
                        table.AddCell(dPrice15.Text);
                        table.AddCell("Day 16     ");
                        table.AddCell(dPrice16.Text);

                        table.AddCell("Day 17     ");
                        table.AddCell(dPrice17.Text);
                        table.AddCell("Day 18     ");
                        table.AddCell(dPrice18.Text);

                        table.AddCell("Day 19     ");
                        table.AddCell(dPrice19.Text);
                        table.AddCell("Day 20     ");
                        table.AddCell(dPrice20.Text);

                        table.AddCell("Day 21     ");
                        table.AddCell(dPrice21.Text);
                        table.AddCell("Day 22     ");
                        table.AddCell(dPrice22.Text);

                        table.AddCell("Day 23     ");
                        table.AddCell(dPrice23.Text);
                        table.AddCell("Day 24     ");
                        table.AddCell(dPrice24.Text);

                        table.AddCell("Day 25     ");
                        table.AddCell(dPrice25.Text);
                        table.AddCell("Day 26     ");
                        table.AddCell(dPrice26.Text);

                        table.AddCell("Day 27     ");
                        table.AddCell(dPrice27.Text);
                        table.AddCell("Day 28     ");
                        table.AddCell(dPrice28.Text);

                        table.AddCell("Day 29     ");
                        table.AddCell(dPrice29.Text);
                        table.AddCell("Day 30     ");
                        table.AddCell(dPrice30.Text);

                        table.AddCell("Day 31     ");
                        table.AddCell(dPrice31.Text);
                        table.AddCell("TOTAL");
                        table.AddCell(reportMonthlyTot.Text);

                        doc.Add(table);

                        var PMChartImg = new MemoryStream();
                        payMethodsChart.SaveImage(PMChartImg, ChartImageFormat.Png);
                        iTextSharp.text.Image PMChart_image = iTextSharp.text.Image.GetInstance(PMChartImg.GetBuffer());
                        PMChart_image.ScalePercent(90f);
                        doc.Add(PMChart_image);

                        var PMTChartImg = new MemoryStream();
                        TotDueTopayMethodChart.SaveImage(PMTChartImg, ChartImageFormat.Png);
                        iTextSharp.text.Image PMTChart_image = iTextSharp.text.Image.GetInstance(PMTChartImg.GetBuffer());
                        PMTChart_image.ScalePercent(90f);
                        doc.Add(PMTChart_image);

                        var incmChartImg = new MemoryStream();
                        montlyIncmChart.SaveImage(incmChartImg, ChartImageFormat.Png);
                        iTextSharp.text.Image incmChart_image = iTextSharp.text.Image.GetInstance(incmChartImg.GetBuffer());
                        doc.Add(incmChart_image);


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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void paymentMethodChart(String m, String y)
        {
            int pmc = IncomeDB.getAvgPaymentMethodsForMonth("Cash", m, y);
            int pmch = IncomeDB.getAvgPaymentMethodsForMonth("Cheque", m, y);
            int pmv = IncomeDB.getAvgPaymentMethodsForMonth("Visa", m, y);
            int pmm = IncomeDB.getAvgPaymentMethodsForMonth("Master", m, y);

            payMethodsChart.Series.Clear();
            payMethodsChart.Series.Add("pMenthods");
            payMethodsChart.Series["pMenthods"].ChartType = SeriesChartType.Doughnut;

            payMethodsChart.Series["pMenthods"].Points.AddXY("Cash", pmc);
            payMethodsChart.Series["pMenthods"].Points.AddXY("Cheque", pmch);
            payMethodsChart.Series["pMenthods"].Points.AddXY("Visa", pmv);
            payMethodsChart.Series["pMenthods"].Points.AddXY("Master", pmm);
        }

        public void paymentMethodTotChart(String m, String y)
        {
            int pmc = IncomeDB.getTotPaymentsForMonth("Cash", m, y);
            int pmch = IncomeDB.getTotPaymentsForMonth("Cheque", m, y);
            int pmv = IncomeDB.getTotPaymentsForMonth("Visa", m, y);
            int pmm = IncomeDB.getTotPaymentsForMonth("Master", m, y);

            TotDueTopayMethodChart.Series.Clear();
            TotDueTopayMethodChart.Series.Add("pMenthodTot");
            TotDueTopayMethodChart.Series["pMenthodTot"].ChartType = SeriesChartType.Doughnut;

            TotDueTopayMethodChart.Series["pMenthodTot"].Points.AddXY("Cash", pmc);
            TotDueTopayMethodChart.Series["pMenthodTot"].Points.AddXY("Cheque", pmch);
            TotDueTopayMethodChart.Series["pMenthodTot"].Points.AddXY("Visa", pmv);
            TotDueTopayMethodChart.Series["pMenthodTot"].Points.AddXY("Master", pmm);
        }

        private void loadReportIntoForm_Click(object sender, EventArgs e)
        {
            String sPrice = Convert.ToString(trgtPriceTxt.Text);

            if (calviewcombomonth.Text == string.Empty || calviewcomboyear.Text == string.Empty)
            {
                MessageBox.Show("Please select a Month and Year");
                return;
            }

            try
            {
                tPrice = Convert.ToInt32(trgtPriceTxt.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Do not enter letters or any other symbol");
                return;
            }

            monthlyReportHeading.Text = calviewcomboyear.Text + " / " + calviewcombomonth.Text + " Monthly Report";

            //loadMotnhlyDeialsToForm();
            display();


            if (tPrice <= 0)
            {
                MessageBox.Show("Target price can not be 0 or bleow");
                return;
            }
            if (tPrice <= Convert.ToInt32(reportMonthlyTot.Text))
            {
                targetStatus.Text = "Target Achieved";
            }
            if (tPrice >= Convert.ToInt32(reportMonthlyTot.Text))
            {
                targetStatus.Text = "Target Failed";
                //targetStatus.Text
            }

            paymentMethodChart(calviewcombomonth.Text, calviewcomboyear.Text);
            paymentMethodTotChart(calviewcombomonth.Text, calviewcomboyear.Text);
        }

        public void display()
        {
            string qr = "select Day, sum(Price) as 'Price' from " + IncomeDB.tbl + " where Month = '" + calviewcombomonth.Text + "' and Year = '" + calviewcomboyear.Text + "' group by Day";
            IncomeDB.DisplayIncome(qr, DailyDetaildataGridView);

            load_Calendar_Chart();

        }

        public void load_Calendar_Chart()
        {
            int count = DailyDetaildataGridView.RowCount;
            int totPrice = 0;

            dPrice1.Text = "0";
            dPrice2.Text = "0";
            dPrice3.Text = "0";
            dPrice4.Text = "0";
            dPrice5.Text = "0";
            dPrice6.Text = "0";
            dPrice7.Text = "0";
            dPrice8.Text = "0";
            dPrice9.Text = "0";
            dPrice10.Text = "0";
            dPrice11.Text = "0";
            dPrice12.Text = "0";
            dPrice13.Text = "0";
            dPrice14.Text = "0";
            dPrice15.Text = "0";
            dPrice16.Text = "0";
            dPrice17.Text = "0";
            dPrice18.Text = "0";
            dPrice19.Text = "0";
            dPrice20.Text = "0";
            dPrice21.Text = "0";
            dPrice22.Text = "0";
            dPrice23.Text = "0";
            dPrice24.Text = "0";
            dPrice25.Text = "0";
            dPrice26.Text = "0";
            dPrice27.Text = "0";
            dPrice28.Text = "0";
            dPrice29.Text = "0";
            dPrice30.Text = "0";
            dPrice31.Text = "0";

            for (int i = 0; i < count; i++)
            {
                int dayNo = Convert.ToInt32(DailyDetaildataGridView.Rows[i].Cells[0].Value.ToString());
                String dayStr = DailyDetaildataGridView.Rows[i].Cells[0].Value.ToString();
                int priceNo = Convert.ToInt32(DailyDetaildataGridView.Rows[i].Cells[1].Value.ToString());

                totPrice += priceNo;

                if (dayNo == 1)
                {
                    dPrice1.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 2)
                {
                    dPrice2.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 3)
                {
                    dPrice3.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 4)
                {
                    dPrice4.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 5)
                {
                    dPrice5.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 6)
                {
                    dPrice6.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 7)
                {
                    dPrice7.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 8)
                {
                    dPrice8.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 9)
                {
                    dPrice9.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 10)
                {
                    dPrice10.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 11)
                {
                    dPrice11.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 12)
                {
                    dPrice12.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 13)
                {
                    dPrice13.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 14)
                {
                    dPrice14.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 15)
                {
                    dPrice15.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 16)
                {
                    dPrice16.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 17)
                {
                    dPrice17.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 18)
                {
                    dPrice18.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 19)
                {
                    dPrice19.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 20)
                {
                    dPrice20.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 21)
                {
                    dPrice21.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 22)
                {
                    dPrice22.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 23)
                {
                    dPrice23.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 24)
                {
                    dPrice24.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 25)
                {
                    dPrice25.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 26)
                {
                    dPrice26.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 27)
                {
                    dPrice27.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 28)
                {
                    dPrice28.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 29)
                {
                    dPrice29.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 30)
                {
                    dPrice30.Text = Convert.ToString(priceNo);
                }
                else if (dayNo == 31)
                {
                    dPrice31.Text = Convert.ToString(priceNo);
                }
                else
                {
                    MessageBox.Show("Error!");
                    return;
                }

            }

            reportMonthlyTot.Text = Convert.ToString(totPrice);
            dailyTrget = Convert.ToInt32(trgtPriceTxt.Text) / 30;

            loadDailyIncomeChart();
        }

        private void panelDailyIncmContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void payMethodsChart_Click(object sender, EventArgs e)
        {

        }

        private void TotDueTopayMethodChart_Click(object sender, EventArgs e)
        {

        }

        private void DailyDetaildataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
