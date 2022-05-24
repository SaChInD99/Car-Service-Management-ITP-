namespace EmployeeSalary
{
    partial class piechart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.yrdiscntcombo = new System.Windows.Forms.ComboBox();
            this.btnmonth = new System.Windows.Forms.Button();
            this.discountpiechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.discountpiechart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yrdiscntcombo
            // 
            this.yrdiscntcombo.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yrdiscntcombo.FormattingEnabled = true;
            this.yrdiscntcombo.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021"});
            this.yrdiscntcombo.Location = new System.Drawing.Point(496, 162);
            this.yrdiscntcombo.Name = "yrdiscntcombo";
            this.yrdiscntcombo.Size = new System.Drawing.Size(187, 33);
            this.yrdiscntcombo.TabIndex = 1;
            // 
            // btnmonth
            // 
            this.btnmonth.BackColor = System.Drawing.Color.LimeGreen;
            this.btnmonth.FlatAppearance.BorderSize = 0;
            this.btnmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmonth.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmonth.Location = new System.Drawing.Point(496, 211);
            this.btnmonth.Name = "btnmonth";
            this.btnmonth.Size = new System.Drawing.Size(187, 48);
            this.btnmonth.TabIndex = 2;
            this.btnmonth.Text = "Submit Year";
            this.btnmonth.UseVisualStyleBackColor = false;
            this.btnmonth.Click += new System.EventHandler(this.btnmonth_Click);
            // 
            // discountpiechart
            // 
            chartArea1.Name = "ChartArea1";
            this.discountpiechart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.discountpiechart.Legends.Add(legend1);
            this.discountpiechart.Location = new System.Drawing.Point(60, 138);
            this.discountpiechart.Name = "discountpiechart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "S1";
            this.discountpiechart.Series.Add(series1);
            this.discountpiechart.Size = new System.Drawing.Size(404, 361);
            this.discountpiechart.TabIndex = 3;
            this.discountpiechart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yearly Discount Distribution";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 90);
            this.panel1.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(743, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 61);
            this.button8.TabIndex = 6;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yes : Discounted";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "No : Not Discounted";
            // 
            // piechart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 568);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.discountpiechart);
            this.Controls.Add(this.btnmonth);
            this.Controls.Add(this.yrdiscntcombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "piechart";
            this.Text = "piechart";
            this.Load += new System.EventHandler(this.piechart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.discountpiechart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox yrdiscntcombo;
        private System.Windows.Forms.Button btnmonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart discountpiechart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}