using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    class DbEmployee
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=csm;SslMode=none";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public static void AddEmployee(Employee std)
        {
            string sql = "INSERT INTO employee VALUES (NULL,@EmployeeName,@EmployeeID,@NIC,@DOB,@Adress,@EmployeeEmail,@ContactNumber,@Attendence,@OT)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@EmployeeName", MySqlDbType.VarChar).Value = std.EmployeeName;
            cmd.Parameters.Add("@EmployeeID", MySqlDbType.VarChar).Value = std.EmployeeID;
            cmd.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = std.NIC;
            cmd.Parameters.Add("@DOB", MySqlDbType.VarChar).Value = std.DOB;
            cmd.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = std.Adress;
            cmd.Parameters.Add("@EmployeeEmail", MySqlDbType.VarChar).Value = std.EmployeeEmail;
            cmd.Parameters.Add("@ContactNumber", MySqlDbType.VarChar).Value = std.ContactNumber;
            cmd.Parameters.Add("@Attendence", MySqlDbType.VarChar).Value = std.Attendence;
            cmd.Parameters.Add("@OT", MySqlDbType.VarChar).Value = std.OT;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EmployeeSalary not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateEmployee(Employee std, string id)
        {
            string sql = "UPDATE employee SET EmployeeName=@EmployeeName,EmployeeID=@EmployeeID,NIC = @NIC,DOB=@DOB,Adress=@Adress,EmployeeEmail=@EmployeeEmail,ContactNumber=@ContactNumber,Attendence=@Attendence,OT=@OT WHERE ID = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@EmployeeName", MySqlDbType.VarChar).Value = std.EmployeeName;
            cmd.Parameters.Add("@EmployeeID", MySqlDbType.VarChar).Value = std.EmployeeID;
            cmd.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = std.NIC;
            cmd.Parameters.Add("@DOB", MySqlDbType.VarChar).Value = std.DOB;
            cmd.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = std.Adress;
            cmd.Parameters.Add("@EmployeeEmail", MySqlDbType.VarChar).Value = std.EmployeeEmail;
            cmd.Parameters.Add("@ContactNumber", MySqlDbType.VarChar).Value = std.ContactNumber;
            cmd.Parameters.Add("@Attendence", MySqlDbType.VarChar).Value = std.Attendence;
            cmd.Parameters.Add("@OT", MySqlDbType.VarChar).Value = std.OT;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EmployeeSalary not update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteEmployee(String id)
        {
            string sql = "DELETE FROM employee WHERE ID = @EmployeeID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType =CommandType.Text;
            cmd.Parameters.Add("@EmployeeID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EmployeeSalary not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        public static String validateUsername(string Uname)
        {
            try
            {
                int x;
                string g = "";

                MySqlConnection con = GetConnection();
                string sqlq = "select username from login where username='" + Uname + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    g = dr["username"].ToString();
                    return g;
                }



                return g;
            }
            catch (Exception ex)
            {



            }



            return "";
        }

        public static String validateUsernameAndPassword(string Uname, String Pass)
        {
            try
            {
                int x;
                string g = "";

                MySqlConnection con = GetConnection();
                string sqlq = "select password from login where username = '" + Uname + "' and password = '"+Pass+"'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    g = dr["password"].ToString();
                    return g;
                }



                return g;
            }
            catch (Exception ex)
            {



            }



            return "";
        }
    }
}