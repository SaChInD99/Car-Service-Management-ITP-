using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MySql.Data.MySqlClient;

namespace Suppliermanage
{
    public partial class Form1sup : Form
    {
        OpenFileDialog ofdAttachment;
        string fileName = "";
        public Form1sup()
        {
            InitializeComponent();
        }
       

        /*public void Order()
        {
            //sup2.Text = "Update Supplier";
            //registerbtn.Text = "Update";
            textBox2.Text = companyname;
            textBox3.Text = address;
            textBox4.Text = country;
            textBox5.Text = contactnumber;
            textBox6.Text = email;
            textBox7.Text = Item_Id;
            comboBox1.Text = itemtype;
            textBox9.Text = description;
            textBox10.Text = date;
        }*/

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment = new OpenFileDialog();
                ofdAttachment.Filter = "Images(.jpg,.png)|*.png;*.jpg;|Pdf Files|*.pdf";
                if (ofdAttachment.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofdAttachment.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //Smpt Client Details
                //gmail >> smtp server : smtp.gmail.com, port : 587 , ssl required
                //yahoo >> smtp server : smtp.mail.yahoo.com, port : 587 , ssl required
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = Convert.ToInt32(txtPortNumber.Text.Trim());
                clientDetails.Host = txtSmtpServer.Text.Trim();
                clientDetails.EnableSsl = cbxSSL.Checked;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(txtSenderEmail.Text.Trim(), txtSenderPassword.Text.Trim());

                //Message Details
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(txtSenderEmail.Text.Trim());
                mailDetails.To.Add(txtRecipientEmail.Text.Trim());
                //for multiple recipients
                //mailDetails.To.Add("another recipient email address");
                //for bcc
                //mailDetails.Bcc.Add("bcc email address")
                mailDetails.Subject = txtSubject.Text.Trim();
                mailDetails.IsBodyHtml = cbxHtmlBody.Checked;
                mailDetails.Body = rtbBody.Text.Trim();


                //file attachment
                if (fileName.Length > 0)
                {
                    Attachment attachment = new Attachment(fileName);
                    mailDetails.Attachments.Add(attachment);
                }

                clientDetails.Send(mailDetails);
                MessageBox.Show("Your mail has been sent.");
                fileName = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                new supplierlist().ShowDialog();
            }
        }

        private void rtbBody_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1sup_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; SslMode = none");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM csm.liststock_table", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "liststock_table");
                //dataGridView2.DataSource = ds.Tables["liststock_table"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSenderEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
