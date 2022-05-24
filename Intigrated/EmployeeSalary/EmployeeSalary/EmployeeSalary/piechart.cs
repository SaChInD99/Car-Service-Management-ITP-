using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class piechart : Form
    {
        public piechart()
        {
            InitializeComponent();
        }


        private void btnmonth_Click(object sender, EventArgs e)
        {
            if (yrdiscntcombo.Text == string.Empty)
            {
                MessageBox.Show("Please select a Year");
                return;
            }

            viewdiscountcount(yrdiscntcombo.Text);
        }

        public void viewdiscountcount(String y)
        {
           


            int count1 = DbCustomer.pieCount(y, "No");
            int count2 = DbCustomer.pieCount(y, "Yes");

            discountpiechart.Series["S1"].Points.AddXY("No",count1);
            discountpiechart.Series["S1"].Points.AddXY("Yes",count2);
        }

        private void piechart_Load(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
