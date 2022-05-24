using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class UpdateVehicle : Form
    {
        public UpdateVehicle()
        {
            InitializeComponent();
            load();
        }



        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csm;Sslmode=none;");
        MySqlCommand cmd;
        MySqlDataReader dr;
        String sql;
        bool Mode = true;
        string id;



         public static MySqlConnection GetConnection() 
        {

            string sql = "datasource=localhost;port=3306;username=root;password=;database=csm;Sslmode=none;";
            MySqlConnection con = new MySqlConnection(sql);
            try 
            {
                con.Open();
            }
            catch(MySqlException ex)
            {

                MessageBox.Show("MySql Connection \n" + ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return con;
        }




        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //fix rectangle curves
            // button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));

            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.ResetText();
            textBox6.Clear();


        }

        //To Refresh the Data grid
        public void load()
        {
            sql = "select * from vehicle_table";
            cmd = new MySqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);

            }

            con.Close();

        }

        //Get The Valued To text fiealds with the Id
        public void getID(String id)
        {

            sql = "select * from vehicle_table where Vid= '" + id + "'   ";
            cmd = new MySqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                comboBox1.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();
         
            }

            con.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get The Values To text Feialds
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                textBox1.Enabled = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                getID(id);




            }
            //Delete Record From DB
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "delete from vehicle_table where Vid = @ViD";
                con.Open();
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ViD", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Record Successfull Deleted!. ");

                con.Close();


            }
            load();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Vid = textBox1.Text;
            string Vcol = textBox3.Text;
            string Vehicle_num = textBox2.Text;
            string Vtyp = textBox4.Text;
            string VCon = comboBox1.SelectedItem.ToString();
            string NIC = textBox6.Text;

            if (Mode == false)
            {

                sql = "UPDATE vehicle_table Set Vehicle_num = @Vehicle_num,Vcol= @Vcol,Vtype= @Vtype, Vcon = @Vcon, NIC = @NIC where Vid = @Vid";
                con.Open();
                cmd = new MySqlCommand(sql, con);

                
                cmd.Parameters.AddWithValue("@Vcol", Vcol);
                cmd.Parameters.AddWithValue("@Vehicle_num", Vehicle_num);
                cmd.Parameters.AddWithValue("@Vtype", Vtyp);
                cmd.Parameters.AddWithValue("@Vcon", VCon);
                cmd.Parameters.AddWithValue("@NIC", NIC);
                cmd.Parameters.AddWithValue("@Vid", Vid);


                //Execute the Query
                cmd.ExecuteNonQuery();
                MessageBox.Show(" All EmployeeSalary Details are Successfuly Updated!! ");

                textBox1.Enabled = true;
                Mode = true;
                

            }
            else
            {
                MessageBox.Show("Details Not Updated!!");
            }

            con.Close();
            load();
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleHome VM = new VehicleHome();
            VM.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    
      

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            new BackupTesting().ShowDialog();
        }
    }
}
