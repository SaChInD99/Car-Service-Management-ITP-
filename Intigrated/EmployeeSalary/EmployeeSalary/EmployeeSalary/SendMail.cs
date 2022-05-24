using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;

namespace EmployeeSalary
{
    public partial class SendMail : Form
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

        //for the file attachment:used for pop up window to select a file for attachment
        OpenFileDialog ofdAttachment;
        String fileName = "";

        public SendMail()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //fix rectangle curves
            btnBrowseFile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBrowseFile.Width, btnBrowseFile.Height, 12, 12));
            btnSendEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSendEmail.Width, btnSendEmail.Height, 12, 12));

        }

        private void SendMail_Load(object sender, EventArgs e)
        {

            //fix rectangle curves
            btnBrowseFile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBrowseFile.Width, btnBrowseFile.Height, 12, 12));
            btnSendEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSendEmail.Width, btnSendEmail.Height, 12, 12));
           




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment = new OpenFileDialog();
                ofdAttachment.Filter = "Images(.jpg,.png)|*.png;*.jpg;*|Pdf Files|*.pdf";
                if(ofdAttachment.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofdAttachment.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                //Port: 465(SSL required)
                //smtp client details
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
                mailDetails.To.Add(txtReciepientEmail.Text.Trim());
                //for multiple recipients
                //mailDetails.To.Add("another recipient email address");
                //for bcc
                //mailDetails.Bcc.Add("bcc email address")
                mailDetails.Subject = txtSubject.Text.Trim();
                mailDetails.IsBodyHtml = cbxHtmlBody.Checked;
                mailDetails.Body = Body.Text.Trim();

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

        private void button8_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
 