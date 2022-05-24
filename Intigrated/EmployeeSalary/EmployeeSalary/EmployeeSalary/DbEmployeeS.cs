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
    class DbEmployeeS
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
        public static void AddEmployeeS(EmployeeSalary std)
        {
            string sql = "INSERT INTO employees VALUES (NULL,@EmployeeSalaryID,@EmployeeName,@EmployeeID,@EmployeeEmail,@OT,@ContactNumber,@Basic,@Attendence,@CalculatedSalary,@Month,@Year)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@EmployeeSalaryID", MySqlDbType.VarChar).Value = std.EmployeeSalaryID;
            cmd.Parameters.Add("@EmployeeName", MySqlDbType.VarChar).Value = std.EmployeeName;
            cmd.Parameters.Add("@EmployeeID", MySqlDbType.VarChar).Value = std.EmployeeID;
            cmd.Parameters.Add("@EmployeeEmail", MySqlDbType.VarChar).Value = std.EmployeeEmail;
            cmd.Parameters.Add("@OT", MySqlDbType.VarChar).Value = std.OT;
            cmd.Parameters.Add("@ContactNumber", MySqlDbType.VarChar).Value = std.ContactNumber;
            cmd.Parameters.Add("@Basic", MySqlDbType.VarChar).Value = std.Basic;
            cmd.Parameters.Add("@Attendence", MySqlDbType.VarChar).Value = std.Attendence;
            cmd.Parameters.Add("@CalculatedSalary", MySqlDbType.VarChar).Value = std.CalculatedSalary;
            cmd.Parameters.Add("@Month", MySqlDbType.VarChar).Value = std.Month;
            cmd.Parameters.Add("@Year", MySqlDbType.Int32).Value = std.Year;
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

        public static void UpdateEmployeeS(EmployeeSalary std, string id)
        {
            string sql = "UPDATE employees SET EmployeeSalaryID = @EmployeeSalaryID, EmployeeName=@EmployeeName,EmployeeID=@EmployeeID,EmployeeEmail=@EmployeeEmail,OT=@OT,ContactNumber=@ContactNumber,Basic=@Basic,Attendence=@Attendence,CalculatedSalary=@CalculatedSalary, Month = @Month ,Year=@Year WHERE ID = @ID ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@EmployeeSalaryID", MySqlDbType.VarChar).Value = std.EmployeeSalaryID;
            cmd.Parameters.Add("@EmployeeName", MySqlDbType.VarChar).Value = std.EmployeeName;
            cmd.Parameters.Add("@EmployeeID", MySqlDbType.VarChar).Value = std.EmployeeID;
            cmd.Parameters.Add("@EmployeeEmail", MySqlDbType.VarChar).Value = std.EmployeeEmail;
            cmd.Parameters.Add("@OT", MySqlDbType.VarChar).Value = std.OT;
            cmd.Parameters.Add("@ContactNumber", MySqlDbType.VarChar).Value = std.ContactNumber;
            cmd.Parameters.Add("@Basic", MySqlDbType.VarChar).Value = std.Basic;
            cmd.Parameters.Add("@Attendence", MySqlDbType.VarChar).Value = std.Attendence;
            cmd.Parameters.Add("@CalculatedSalary", MySqlDbType.VarChar).Value = std.CalculatedSalary;
            cmd.Parameters.Add("@Month", MySqlDbType.VarChar).Value = std.Month;
            cmd.Parameters.Add("@Year", MySqlDbType.Int32).Value = std.Year;
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
        public static void UpdateEmployeeS2(EmployeeSalary std, string id)
        {
            string sql = "INSERT INTO employees VALUES (NULL,@EmployeeSalaryID,@EmployeeName,@EmployeeID,@EmployeeEmail,@OT,@ContactNumber,@Basic,@Attendence,@CalculatedSalary,@Month,@Year) ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@EmployeeSalaryID", MySqlDbType.VarChar).Value = std.EmployeeSalaryID;
            cmd.Parameters.Add("@EmployeeName", MySqlDbType.VarChar).Value = std.EmployeeName;
            cmd.Parameters.Add("@EmployeeID", MySqlDbType.VarChar).Value = std.EmployeeID;
            cmd.Parameters.Add("@EmployeeEmail", MySqlDbType.VarChar).Value = std.EmployeeEmail;
            cmd.Parameters.Add("@OT", MySqlDbType.VarChar).Value = std.OT;
            cmd.Parameters.Add("@ContactNumber", MySqlDbType.VarChar).Value = std.ContactNumber;
            cmd.Parameters.Add("@Basic", MySqlDbType.VarChar).Value = std.Basic;
            cmd.Parameters.Add("@Attendence", MySqlDbType.VarChar).Value = std.Attendence;
            cmd.Parameters.Add("@CalculatedSalary", MySqlDbType.VarChar).Value = std.CalculatedSalary;
            cmd.Parameters.Add("@Month", MySqlDbType.VarChar).Value = std.Month;
            cmd.Parameters.Add("@Year", MySqlDbType.Int32).Value = std.Year;
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

        public static void DeleteEmployeeSalary(String id)
        {
            string sql = "DELETE FROM employees WHERE ID = @EmployeeSalaryID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType =CommandType.Text;
            cmd.Parameters.Add("@EmployeeSalaryID", MySqlDbType.VarChar).Value = id;
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

        public static int getThisMonthTotalOutgoing(string mm, string yy)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select sum(CalculatedSalary) as 'sum' from employees where Month = '" + mm + "' and Year = " + yy;
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["sum"].ToString();
                    x = Convert.ToInt32(g);
                    return x;
                }

                return 0;
            }
            catch (Exception ex)
            {

            }

            return 0;
        }

   

        public static int getMonthlyTolalSalary(string m, string y)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select sum(CalculatedSalary) as 'sum' from employees where Month = '" + m + "' and Year = " + y;
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["sum"].ToString();
                    x = Convert.ToInt32(g);
                    return x;
                }

                return 0;
            }
            catch (Exception ex)
            {

            }

            return 0;
        }
    
    }
}