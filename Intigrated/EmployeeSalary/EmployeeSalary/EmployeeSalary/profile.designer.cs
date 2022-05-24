namespace EmployeeSalary
{
    partial class panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pEmail = new System.Windows.Forms.Label();
            this.pContactNumber = new System.Windows.Forms.Label();
            this.csAddress = new System.Windows.Forms.TextBox();
            this.pAddress = new System.Windows.Forms.Label();
            this.csName = new System.Windows.Forms.TextBox();
            this.pCustomerName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pcustomerID = new System.Windows.Forms.Label();
            this.csNic = new System.Windows.Forms.TextBox();
            this.csContact = new System.Windows.Forms.TextBox();
            this.csEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 105);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(743, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 74);
            this.button8.TabIndex = 19;
            this.button8.Text = "x";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(151, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 51);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Essential Details";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pEmail
            // 
            this.pEmail.AutoSize = true;
            this.pEmail.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pEmail.Location = new System.Drawing.Point(42, 542);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(64, 30);
            this.pEmail.TabIndex = 8;
            this.pEmail.Text = "Email";
            // 
            // pContactNumber
            // 
            this.pContactNumber.AutoSize = true;
            this.pContactNumber.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pContactNumber.Location = new System.Drawing.Point(42, 481);
            this.pContactNumber.Name = "pContactNumber";
            this.pContactNumber.Size = new System.Drawing.Size(173, 30);
            this.pContactNumber.TabIndex = 6;
            this.pContactNumber.Text = "Contact Number";
            // 
            // csAddress
            // 
            this.csAddress.BackColor = System.Drawing.Color.White;
            this.csAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.csAddress.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csAddress.Location = new System.Drawing.Point(226, 419);
            this.csAddress.Multiline = true;
            this.csAddress.Name = "csAddress";
            this.csAddress.Size = new System.Drawing.Size(497, 44);
            this.csAddress.TabIndex = 5;
            this.csAddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pAddress
            // 
            this.pAddress.AutoSize = true;
            this.pAddress.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAddress.Location = new System.Drawing.Point(42, 419);
            this.pAddress.Name = "pAddress";
            this.pAddress.Size = new System.Drawing.Size(90, 30);
            this.pAddress.TabIndex = 4;
            this.pAddress.Text = "Address";
            // 
            // csName
            // 
            this.csName.BackColor = System.Drawing.Color.White;
            this.csName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.csName.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csName.Location = new System.Drawing.Point(226, 361);
            this.csName.Multiline = true;
            this.csName.Name = "csName";
            this.csName.Size = new System.Drawing.Size(497, 32);
            this.csName.TabIndex = 3;
            this.csName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pCustomerName
            // 
            this.pCustomerName.AutoSize = true;
            this.pCustomerName.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCustomerName.Location = new System.Drawing.Point(46, 361);
            this.pCustomerName.Name = "pCustomerName";
            this.pCustomerName.Size = new System.Drawing.Size(169, 30);
            this.pCustomerName.TabIndex = 2;
            this.pCustomerName.Text = "Customer Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, -39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pcustomerID
            // 
            this.pcustomerID.AutoSize = true;
            this.pcustomerID.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcustomerID.ForeColor = System.Drawing.Color.Black;
            this.pcustomerID.Location = new System.Drawing.Point(42, 291);
            this.pcustomerID.Name = "pcustomerID";
            this.pcustomerID.Size = new System.Drawing.Size(147, 30);
            this.pcustomerID.TabIndex = 0;
            this.pcustomerID.Text = "Customer NIC";
            // 
            // csNic
            // 
            this.csNic.BackColor = System.Drawing.Color.White;
            this.csNic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.csNic.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csNic.Location = new System.Drawing.Point(226, 298);
            this.csNic.Multiline = true;
            this.csNic.Name = "csNic";
            this.csNic.Size = new System.Drawing.Size(497, 30);
            this.csNic.TabIndex = 18;
            // 
            // csContact
            // 
            this.csContact.BackColor = System.Drawing.Color.White;
            this.csContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.csContact.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csContact.Location = new System.Drawing.Point(226, 484);
            this.csContact.Multiline = true;
            this.csContact.Name = "csContact";
            this.csContact.Size = new System.Drawing.Size(497, 32);
            this.csContact.TabIndex = 22;
            // 
            // csEmail
            // 
            this.csEmail.BackColor = System.Drawing.Color.White;
            this.csEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.csEmail.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csEmail.Location = new System.Drawing.Point(226, 552);
            this.csEmail.Multiline = true;
            this.csEmail.Name = "csEmail";
            this.csEmail.Size = new System.Drawing.Size(497, 32);
            this.csEmail.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(803, 631);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.csEmail);
            this.Controls.Add(this.csContact);
            this.Controls.Add(this.csNic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcustomerID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pCustomerName);
            this.Controls.Add(this.csName);
            this.Controls.Add(this.pAddress);
            this.Controls.Add(this.pEmail);
            this.Controls.Add(this.csAddress);
            this.Controls.Add(this.pContactNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pEmail;
        private System.Windows.Forms.Label pContactNumber;
        private System.Windows.Forms.TextBox csAddress;
        private System.Windows.Forms.Label pAddress;
        private System.Windows.Forms.TextBox csName;
        private System.Windows.Forms.Label pCustomerName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pcustomerID;
        private System.Windows.Forms.TextBox csNic;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox csContact;
        private System.Windows.Forms.TextBox csEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}