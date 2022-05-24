
namespace EmployeeSalary
{
    partial class BackupTesting
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
            this.backupBtn = new System.Windows.Forms.Button();
            this.progressBarbckp = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(129, 51);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(170, 78);
            this.backupBtn.TabIndex = 0;
            this.backupBtn.Text = "Backup";
            this.backupBtn.UseVisualStyleBackColor = true;
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // progressBarbckp
            // 
            this.progressBarbckp.Location = new System.Drawing.Point(74, 158);
            this.progressBarbckp.Name = "progressBarbckp";
            this.progressBarbckp.Size = new System.Drawing.Size(286, 23);
            this.progressBarbckp.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackupTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBarbckp);
            this.Controls.Add(this.backupBtn);
            this.Name = "BackupTesting";
            this.Text = "BackupTesting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.ProgressBar progressBarbckp;
        private System.Windows.Forms.Button button1;
    }
}