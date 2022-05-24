namespace EmployeeSalary
{
    partial class addcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addcustomer));
            this.btnGet = new System.Windows.Forms.Button();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbVehicle = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.tbCustomername = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltext = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtArrivalMonth = new System.Windows.Forms.Label();
            this.tbArrivalMonth = new System.Windows.Forms.TextBox();
            this.tbArrivalTime = new System.Windows.Forms.TextBox();
            this.tbBookingID = new System.Windows.Forms.TextBox();
            this.txtCustomerNIC = new System.Windows.Forms.Label();
            this.tbNIC = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.Label();
            this.txtVehicleno = new System.Windows.Forms.Label();
            this.txtArrivalTime = new System.Windows.Forms.Label();
            this.txtArrivalDay = new System.Windows.Forms.Label();
            this.tbArrivalYear = new System.Windows.Forms.TextBox();
            this.getDateBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGet.FlatAppearance.BorderSize = 0;
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGet.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.ForeColor = System.Drawing.Color.White;
            this.btnGet.Location = new System.Drawing.Point(231, 362);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(264, 44);
            this.btnGet.TabIndex = 18;
            this.btnGet.Text = "Fetch Existing Info";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // tbContact
            // 
            this.tbContact.BackColor = System.Drawing.Color.White;
            this.tbContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContact.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(49, 696);
            this.tbContact.Multiline = true;
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(659, 38);
            this.tbContact.TabIndex = 17;
            this.tbContact.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // tbVehicle
            // 
            this.tbVehicle.BackColor = System.Drawing.Color.White;
            this.tbVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVehicle.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehicle.Location = new System.Drawing.Point(50, 784);
            this.tbVehicle.Multiline = true;
            this.tbVehicle.Name = "tbVehicle";
            this.tbVehicle.Size = new System.Drawing.Size(659, 38);
            this.tbVehicle.TabIndex = 16;
            this.tbVehicle.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.AutoSize = true;
            this.txtContactNumber.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(44, 668);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(155, 25);
            this.txtContactNumber.TabIndex = 14;
            this.txtContactNumber.Text = "Contact Number";
            this.txtContactNumber.Click += new System.EventHandler(this.txtContactNumber_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoSize = true;
            this.txtCustomerName.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(47, 401);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(152, 25);
            this.txtCustomerName.TabIndex = 13;
            this.txtCustomerName.Text = "Customer Name";
            this.txtCustomerName.Click += new System.EventHandler(this.txtCustomerName_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(44, 490);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(80, 25);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Text = "Address";
            this.txtAddress.Click += new System.EventHandler(this.txtAddress_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(45, 581);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(59, 25);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // tbCustomername
            // 
            this.tbCustomername.BackColor = System.Drawing.Color.White;
            this.tbCustomername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCustomername.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomername.Location = new System.Drawing.Point(49, 434);
            this.tbCustomername.Multiline = true;
            this.tbCustomername.Name = "tbCustomername";
            this.tbCustomername.Size = new System.Drawing.Size(660, 38);
            this.tbCustomername.TabIndex = 7;
            this.tbCustomername.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(49, 609);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(660, 38);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.White;
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(50, 518);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(659, 50);
            this.tbAddress.TabIndex = 3;
            this.tbAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbltext);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Font = new System.Drawing.Font("Lato Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 100);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.ForeColor = System.Drawing.Color.Black;
            this.lbltext.Location = new System.Drawing.Point(167, 18);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(505, 65);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "Add Customer Details";
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Lato", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(776, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 67);
            this.button8.TabIndex = 25;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(447, 839);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 53);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(634, 839);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 53);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtArrivalMonth
            // 
            this.txtArrivalMonth.AutoSize = true;
            this.txtArrivalMonth.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrivalMonth.Location = new System.Drawing.Point(267, 183);
            this.txtArrivalMonth.Name = "txtArrivalMonth";
            this.txtArrivalMonth.Size = new System.Drawing.Size(132, 25);
            this.txtArrivalMonth.TabIndex = 29;
            this.txtArrivalMonth.Text = "Arrival Month";
            // 
            // tbArrivalMonth
            // 
            this.tbArrivalMonth.BackColor = System.Drawing.Color.White;
            this.tbArrivalMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArrivalMonth.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArrivalMonth.Location = new System.Drawing.Point(272, 214);
            this.tbArrivalMonth.Multiline = true;
            this.tbArrivalMonth.Name = "tbArrivalMonth";
            this.tbArrivalMonth.Size = new System.Drawing.Size(183, 38);
            this.tbArrivalMonth.TabIndex = 30;
            this.tbArrivalMonth.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // tbArrivalTime
            // 
            this.tbArrivalTime.BackColor = System.Drawing.Color.White;
            this.tbArrivalTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArrivalTime.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArrivalTime.Location = new System.Drawing.Point(497, 214);
            this.tbArrivalTime.Multiline = true;
            this.tbArrivalTime.Name = "tbArrivalTime";
            this.tbArrivalTime.Size = new System.Drawing.Size(212, 38);
            this.tbArrivalTime.TabIndex = 33;
            this.tbArrivalTime.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // tbBookingID
            // 
            this.tbBookingID.BackColor = System.Drawing.Color.White;
            this.tbBookingID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBookingID.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookingID.Location = new System.Drawing.Point(49, 304);
            this.tbBookingID.Multiline = true;
            this.tbBookingID.Name = "tbBookingID";
            this.tbBookingID.Size = new System.Drawing.Size(194, 38);
            this.tbBookingID.TabIndex = 34;
            this.tbBookingID.Text = "none";
            this.tbBookingID.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // txtCustomerNIC
            // 
            this.txtCustomerNIC.AutoSize = true;
            this.txtCustomerNIC.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNIC.Location = new System.Drawing.Point(267, 276);
            this.txtCustomerNIC.Name = "txtCustomerNIC";
            this.txtCustomerNIC.Size = new System.Drawing.Size(133, 25);
            this.txtCustomerNIC.TabIndex = 35;
            this.txtCustomerNIC.Text = "Customer NIC";
            this.txtCustomerNIC.Click += new System.EventHandler(this.txtCustomerNIC_Click);
            // 
            // tbNIC
            // 
            this.tbNIC.BackColor = System.Drawing.Color.White;
            this.tbNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNIC.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNIC.Location = new System.Drawing.Point(266, 304);
            this.tbNIC.Multiline = true;
            this.tbNIC.Name = "tbNIC";
            this.tbNIC.Size = new System.Drawing.Size(443, 38);
            this.tbNIC.TabIndex = 36;
            this.tbNIC.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // txtBookingID
            // 
            this.txtBookingID.AutoSize = true;
            this.txtBookingID.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.Location = new System.Drawing.Point(44, 274);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(107, 25);
            this.txtBookingID.TabIndex = 37;
            this.txtBookingID.Text = "Booking ID";
            this.txtBookingID.Click += new System.EventHandler(this.txtBookingID_Click);
            // 
            // txtVehicleno
            // 
            this.txtVehicleno.AutoSize = true;
            this.txtVehicleno.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleno.Location = new System.Drawing.Point(44, 756);
            this.txtVehicleno.Name = "txtVehicleno";
            this.txtVehicleno.Size = new System.Drawing.Size(104, 25);
            this.txtVehicleno.TabIndex = 38;
            this.txtVehicleno.Text = "Vehicle No";
            this.txtVehicleno.Click += new System.EventHandler(this.txtVehicleno_Click);
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.AutoSize = true;
            this.txtArrivalTime.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrivalTime.Location = new System.Drawing.Point(492, 183);
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.Size = new System.Drawing.Size(157, 25);
            this.txtArrivalTime.TabIndex = 39;
            this.txtArrivalTime.Text = "Arrival DateTime";
            this.txtArrivalTime.Click += new System.EventHandler(this.txtArrivalTime_Click);
            // 
            // txtArrivalDay
            // 
            this.txtArrivalDay.AutoSize = true;
            this.txtArrivalDay.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrivalDay.Location = new System.Drawing.Point(47, 177);
            this.txtArrivalDay.Name = "txtArrivalDay";
            this.txtArrivalDay.Size = new System.Drawing.Size(111, 25);
            this.txtArrivalDay.TabIndex = 40;
            this.txtArrivalDay.Text = "Arrival Year";
            this.txtArrivalDay.Click += new System.EventHandler(this.txtArrivalDay_Click);
            // 
            // tbArrivalYear
            // 
            this.tbArrivalYear.BackColor = System.Drawing.Color.White;
            this.tbArrivalYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArrivalYear.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArrivalYear.Location = new System.Drawing.Point(49, 214);
            this.tbArrivalYear.Multiline = true;
            this.tbArrivalYear.Name = "tbArrivalYear";
            this.tbArrivalYear.Size = new System.Drawing.Size(194, 38);
            this.tbArrivalYear.TabIndex = 28;
            this.tbArrivalYear.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // getDateBtn
            // 
            this.getDateBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.getDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getDateBtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDateBtn.ForeColor = System.Drawing.Color.White;
            this.getDateBtn.Location = new System.Drawing.Point(40, 124);
            this.getDateBtn.Name = "getDateBtn";
            this.getDateBtn.Size = new System.Drawing.Size(240, 50);
            this.getDateBtn.TabIndex = 41;
            this.getDateBtn.Text = "Get timestamp";
            this.getDateBtn.UseVisualStyleBackColor = false;
            this.getDateBtn.Click += new System.EventHandler(this.getDateBtn_Click);
            // 
            // addcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(840, 920);
            this.Controls.Add(this.getDateBtn);
            this.Controls.Add(this.txtArrivalDay);
            this.Controls.Add(this.txtArrivalTime);
            this.Controls.Add(this.txtVehicleno);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.tbNIC);
            this.Controls.Add(this.txtCustomerNIC);
            this.Controls.Add(this.tbBookingID);
            this.Controls.Add(this.tbArrivalTime);
            this.Controls.Add(this.tbArrivalMonth);
            this.Controls.Add(this.txtArrivalMonth);
            this.Controls.Add(this.tbArrivalYear);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbVehicle);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbCustomername);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnGet);
            this.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.addcustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbVehicle;
        private System.Windows.Forms.Label txtContactNumber;
        private System.Windows.Forms.Label txtCustomerName;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox tbCustomername;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label txtArrivalMonth;
        private System.Windows.Forms.TextBox tbArrivalMonth;
        private System.Windows.Forms.TextBox tbArrivalTime;
        private System.Windows.Forms.TextBox tbBookingID;
        private System.Windows.Forms.Label txtCustomerNIC;
        private System.Windows.Forms.TextBox tbNIC;
        private System.Windows.Forms.Label txtBookingID;
        private System.Windows.Forms.Label txtVehicleno;
        private System.Windows.Forms.Label txtArrivalTime;
        private System.Windows.Forms.Label txtArrivalDay;
        private System.Windows.Forms.TextBox tbArrivalYear;
        private System.Windows.Forms.Button getDateBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button8;
    }
}