
namespace EmployeeSalary
{
    partial class EmployeeSalaryReportDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pdfGeneratBtn = new System.Windows.Forms.Button();
            this.dataGridViewrep = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrep)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfGeneratBtn
            // 
            this.pdfGeneratBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfGeneratBtn.BackColor = System.Drawing.Color.Green;
            this.pdfGeneratBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdfGeneratBtn.FlatAppearance.BorderSize = 0;
            this.pdfGeneratBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdfGeneratBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfGeneratBtn.ForeColor = System.Drawing.Color.White;
            this.pdfGeneratBtn.Location = new System.Drawing.Point(11, 704);
            this.pdfGeneratBtn.Name = "pdfGeneratBtn";
            this.pdfGeneratBtn.Size = new System.Drawing.Size(1282, 54);
            this.pdfGeneratBtn.TabIndex = 0;
            this.pdfGeneratBtn.Text = "Genarate Employee Salary Detail PDF";
            this.pdfGeneratBtn.UseVisualStyleBackColor = false;
            this.pdfGeneratBtn.Click += new System.EventHandler(this.pdfGeneratBtn_Click);
            // 
            // dataGridViewrep
            // 
            this.dataGridViewrep.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewrep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewrep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewrep.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewrep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewrep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewrep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewrep.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewrep.Location = new System.Drawing.Point(11, 11);
            this.dataGridViewrep.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewrep.Name = "dataGridViewrep";
            this.dataGridViewrep.ReadOnly = true;
            this.dataGridViewrep.RowHeadersWidth = 51;
            this.dataGridViewrep.RowTemplate.Height = 24;
            this.dataGridViewrep.Size = new System.Drawing.Size(1282, 663);
            this.dataGridViewrep.TabIndex = 1;
            this.dataGridViewrep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewrep_CellContentClick);
            // 
            // EmployeeSalaryReportDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 793);
            this.Controls.Add(this.dataGridViewrep);
            this.Controls.Add(this.pdfGeneratBtn);
            this.Name = "EmployeeSalaryReportDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeSalaryReportDetailForm";
            this.Load += new System.EventHandler(this.EmployeeSalaryReportDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewrep;
        private System.Windows.Forms.Button pdfGeneratBtn;
    }
}