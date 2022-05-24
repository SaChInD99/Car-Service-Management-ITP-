using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class ReportStkForm : Form
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

        public ReportStkForm()
        {
            InitializeComponent();
        }

        public void DisplayCurrent()
        {
            //display details
            StockDB.DisplayAndSearch("SELECT Item_Name, Quantity FROM currentstock_table", dataGridViewCurntStkRprt);

        }
        public void DisplayList()
        {
            //display details
            StockDB.DisplayAndSearch("SELECT Item_Name, Req_Quantity FROM liststock_table", dataGridViewListStkRprt);

        }

        private void ReportStkPrintbtn_Click(object sender, EventArgs e)
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

                        iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("itplogo.png");
                        PNG.ScalePercent(5f);
                        PNG.Alignment = 1;
                        doc.Add(PNG);

                        Paragraph para1 = new Paragraph("ROYAL CAR SERVICE CENTER", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 30f));
                        Paragraph para21 = new Paragraph("Sri Jayawardhanapura");
                        Paragraph para22 = new Paragraph("Kotte");
                        Paragraph para2 = new Paragraph("Stock Management");
                        Paragraph para3 = new Paragraph("Report\n\n\n\n\n\n\n\n\n\n\n\n\n");
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

                        PdfPTable table = new PdfPTable(dataGridViewCurntStkRprt.Columns.Count);

                        PdfPCell cell = new PdfPCell(new Phrase("Current Store Items", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f)));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = 1;
                        table.AddCell(cell);

                        for (int j = 0; j < dataGridViewCurntStkRprt.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dataGridViewCurntStkRprt.Columns[j].HeaderText));
                        }

                        table.HeaderRows = 1;

                        for(int i = 0; i < dataGridViewCurntStkRprt.Rows.Count; i++)
                        {
                            for(int k = 0; k < dataGridViewCurntStkRprt.Columns.Count; k++)
                            {
                                if(dataGridViewCurntStkRprt[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dataGridViewCurntStkRprt[k, i].Value.ToString()));
                                }
                            }
                        }

                        doc.Add(table);
                        Paragraph space = new Paragraph("\n\n\n\n");
                        doc.Add(space);//add to the pdf

                        PdfPTable table1 = new PdfPTable(dataGridViewListStkRprt.Columns.Count);

                        PdfPCell cell1 = new PdfPCell(new Phrase("Ordered Store Items", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f)));
                        cell1.Colspan = 2;
                        cell1.HorizontalAlignment = 1;
                        table1.AddCell(cell1);

                        for (int j = 0; j < dataGridViewListStkRprt.Columns.Count; j++)
                        {
                            table1.AddCell(new Phrase(dataGridViewListStkRprt.Columns[j].HeaderText));
                        }

                        table1.HeaderRows = 1;

                        for (int i = 0; i < dataGridViewListStkRprt.Rows.Count; i++)
                        {
                            for (int k = 0; k < dataGridViewListStkRprt.Columns.Count; k++)
                            {
                                if (dataGridViewListStkRprt[k, i].Value != null)
                                {
                                    table1.AddCell(new Phrase(dataGridViewListStkRprt[k, i].Value.ToString()));
                                }
                            }
                        }

                        doc.Add(table1);
                       


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

        private void ReportStkForm_Load(object sender, EventArgs e)
        {
            DisplayCurrent();
            DisplayList();

            //button corners' to round
            ReportStkPrintbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ReportStkPrintbtn.Width, ReportStkPrintbtn.Height, 15, 15));
        }
    }
}
