using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmployeeSalary
{
    public partial class BackupTesting : Form
    {
        public BackupTesting()
        {
            InitializeComponent();
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            progressBarbckp.Value = 0;
            string d = DateTime.Now.Date.ToString();
            string t = DateTime.Now.TimeOfDay.ToString();
            string sql = "datasource=localhost;port=3306;username=root;password=;database=csm;SslMode=none";
            string file = "D:\\csm\\csm.sql";
            progressBarbckp.Value = 10;
            using (MySqlConnection con = new MySqlConnection(sql))
            {
                progressBarbckp.Value = 30;
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    progressBarbckp.Value = 40;
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        progressBarbckp.Value = 50;
                        cmd.Connection = con;
                        con.Open();
                        try
                        {
                            progressBarbckp.Value = 60;
                            mb.ExportToFile(file);
                            progressBarbckp.Value = 100;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        con.Close();
                    }
                }
            }
            MessageBox.Show("Backup complete");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OutgoingDash().ShowDialog();
        }
    }
}
