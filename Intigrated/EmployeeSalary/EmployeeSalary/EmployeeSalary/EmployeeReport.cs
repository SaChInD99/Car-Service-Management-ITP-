using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
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

namespace EmployeeSalary
{
    public partial class EmployeeReport : Form
    {
        public EmployeeReport()
        {
            InitializeComponent();
        }

        private void pdfGeneratBtn_Click(object sender, EventArgs e)
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

                        iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("projectIcon.png");
                        PNG.ScalePercent(5f);
                        PNG.Alignment = 1;
                        doc.Add(PNG);

                        Paragraph para1 = new Paragraph("ROYAL CAR SERVICE CENTER", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 30f));
                        Paragraph para21 = new Paragraph("Sri Jayawardhanapura", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f));
                        Paragraph para22 = new Paragraph("Kotte", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f));
                        Paragraph para2 = new Paragraph("Employee Management");
                        Paragraph para3 = new Paragraph(DateTime.Now.Year.ToString() + " / " + DateTime.Now.Month.ToString() + " monthly Report\n\n\n\n\n\n\n\n\n\n\n\n\n");
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

                        PdfPTable table = new PdfPTable(dataGridViewrep.Columns.Count);

                        PdfPCell cell = new PdfPCell(new Phrase("ID", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f)));
                        cell.Colspan = 1;
                        cell.HorizontalAlignment = 1;
                        table.AddCell(cell);

                        for (int j = 1; j < dataGridViewrep.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dataGridViewrep.Columns[j].HeaderText));
                        }

 

                        for (int i = 0; i < dataGridViewrep.Rows.Count; i++)
                        {
                            for (int k = 0; k < dataGridViewrep.Columns.Count; k++)
                            {
                                if (dataGridViewrep[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dataGridViewrep[k, i].Value.ToString()));
                                }
                            }
                        }

                        doc.Add(table);
                        Paragraph space = new Paragraph("\n\n\n\n");
                        doc.Add(space);//add to the pdf


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

        private void EmployeeReport_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; SslMode = none");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT ID,EmployeeID, EmployeeName, EmployeeID, EmployeeEmail, OT,ContactNumber,Attendence,DOB,Adress FROM csm.employee", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "employee");
                dataGridViewrep.DataSource = ds.Tables["employee"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
