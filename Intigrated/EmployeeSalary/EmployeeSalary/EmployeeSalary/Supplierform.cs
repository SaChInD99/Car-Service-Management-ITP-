using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Suppliermanage
{
    public partial class Supplierform : Form
    {
        private readonly supplierlist _parent;
       public String sup_id, companyname, address, country, contactnumber, email, Item_Id, itemtype, description, date;

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
        public Supplierform(supplierlist parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        //UPDATE supplier
        public void UpdateInfo()
        {
            sup2.Text = "Update Supplier";
            registerbtn.Text = "Update";
            rtbBody.Text = companyname;
            textBox3.Text = address;
            textBox4.Text = country;
            textBox5.Text = contactnumber;
            textBox6.Text = email;
            textBox7.Text = Item_Id;
            comboBox1.Text = itemtype;
            textBox9.Text = description;
            textBox10.Text = date;
        }

        public void Order()
        {
            rtbBody.Text = companyname;
        }
        public void clear()
        {
             rtbBody.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = comboBox1.Text = textBox9.Text= textBox10.Text = string.Empty;
        }
        private void suppliermanage_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("http://maps.google.com/maps?=");

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            registerbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, registerbtn.Width, registerbtn.Height, 30, 30));
           
            clearbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, clearbtn.Width, clearbtn.Height, 30, 30));

            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToLongDateString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void suplist_Click(object sender, EventArgs e)
        {
            new supplierlist().ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            new supplierlist().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = e.Url.ToString() + "Is Loading......";
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox6_Leave(object sender, EventArgs e) { 
      
        }
        //Email Validation
        private void textBox6_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(textBox6.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email(use @).");
                return;
            }
        }

        //contact number validation
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only allow digits(10 digits)");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //register FORM validation
        private void registerbtn_Click(object sender, EventArgs e)
        {
           
            if(rtbBody.Text.Trim(). Length < 3)
            {
                MessageBox.Show("company name must be more than 3 letters.");
                return;
            }
            if (textBox3.Text.Trim().Length < 5)
            {
                MessageBox.Show("Enter Valid Address(>5).");
                return;
            }
            if (textBox4.Text.Trim().Length < 3)
            {
                MessageBox.Show("Choose Valid Country.");
                return;
            }
            if (textBox5.Text.Trim().Length  < 10)
            {
                MessageBox.Show("enter 10 Digit Contact Number.");
                return;
            }
            if (textBox6.Text.Trim().Length < 3)
            {
                MessageBox.Show("Enter Valid Email(>3).");
                return;
            }
            if (textBox7.Text.Trim().Length < 0)
            {
                MessageBox.Show("");
                return;
            }
            if (comboBox1.Text.Trim().Length < 3)
            {
                MessageBox.Show("Select Item Type");
                return;
            }
            if (textBox9.Text.Trim().Length < 3)
            {
                MessageBox.Show("Discription is empty(>3).");
                return;
            }
            if (textBox10.Text.Trim().Length < 3)
            {
                MessageBox.Show("date is empty(>3).");
                return;
            }
            if (registerbtn.Text == "Register")
            {
                supplier supd = new supplier(textBox1.Text.Trim(), rtbBody.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim(), textBox6.Text.Trim(), textBox7.Text.Trim(),comboBox1.Text.Trim(), textBox9.Text.Trim(), textBox10.Text.Trim());
                dbsupplier.AddSupplier(supd);
                clear();
            }
            if(registerbtn.Text == "Update")
            {
                
                supplier supd = new supplier(textBox1.Text.Trim(), rtbBody.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim(), textBox6.Text.Trim(), textBox7.Text.Trim(), comboBox1.Text.Trim(), textBox9.Text.Trim(), textBox10.Text.Trim());
       
                dbsupplier.UpdateSupplire(supd, sup_id);
            }
            _parent.Display();
            new supplierlist().ShowDialog();
        }

        private void sup2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
