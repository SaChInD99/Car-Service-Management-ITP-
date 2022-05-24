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
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Suppliermanage
{
    
    public partial class reportgrid : Form
    {
        private MySqlConnection connection;

        public reportgrid()
        {
            InitializeComponent();
           
        }

        public void Display()
        {
           // dbsupplier.DisplaySupplier("SELECT  companyname, address FROM suppliermanage", dataGridViewrep);
        }

        private void reportgrid_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; SslMode = none");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Order_Id, Item_Id, Date  FROM csm.liststock_table", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "liststock_table");
                dataGridView1.DataSource = ds.Tables["liststock_table"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; SslMode = none") ;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT sup_id, companyname, country, email, Item_Id FROM csm.suppliermanage", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "suppliermanage");
                dataGridViewrep.DataSource = ds.Tables["suppliermanage"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();
            label1.Text = DateTime.Now.ToLongDateString();

        }

        private void printPdfBtn_Click(object sender, EventArgs e)
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
                        Paragraph para22 = new Paragraph("Kotte", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 30f));
                        Paragraph para2 = new Paragraph("Supplier Management");
                        Paragraph para3 = new Paragraph("Monthly Report\n\n\n\n\n\n\n\n\n\n\n\n\n");
                        Paragraph para4 = new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Paragraph para8 = new Paragraph(label1.Text = DateTime.Now.ToLongDateString()) ;
                        Paragraph para9 = new Paragraph(label2.Text = DateTime.Now.ToLongTimeString());
                        Paragraph para25 = new Paragraph("pdficon.png");                        
                        para1.Alignment = 1;
                        para2.Alignment = 1;
                        para21.Alignment = 1;
                        para22.Alignment = 1;
                        para3.Alignment = 1;
                        para3.Alignment = 1;
                        para8.Alignment = 10;
                        para9.Alignment = 10;
                        para25.Alignment = 1;
                        doc.Add(para1);
                        doc.Add(para21);
                        doc.Add(para22);
                        doc.Add(para2);
                        doc.Add(para3);
                        doc.Add(para4);
                        doc.Add(para8);
                        doc.Add(para9);
                        doc.Add(para25);


                        PdfPTable table = new PdfPTable(dataGridViewrep.Columns.Count);

                        PdfPCell cell = new PdfPCell(new Phrase("Monthly Supplier Details Report", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f)));
                        cell.Colspan = 5;
                        cell.HorizontalAlignment = 1;
                        table.AddCell(cell);

                        for (int j = 0; j < dataGridViewrep.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dataGridViewrep.Columns[j].HeaderText));
                        }

                        table.HeaderRows = 1;

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

                        PdfPTable table1 = new PdfPTable(dataGridView1.Columns.Count);

                        PdfPCell cell1 = new PdfPCell(new Phrase("Monthly Completed Orders", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f)));
                        cell1.Colspan = 3;
                        cell1.HorizontalAlignment = 1;
                        table1.AddCell(cell1);

                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            table1.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
                        }

                        table1.HeaderRows = 1;

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                            {
                                if (dataGridView1[k, i].Value != null)
                                {
                                    table1.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
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

        private void dataGridViewrep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; SslMode = none");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Order_Id, Item_Id,Item_Name FROM csm.liststock_table", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "liststock_table");
                dataGridView1.DataSource = ds.Tables["liststock_table"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
    }
    }

 