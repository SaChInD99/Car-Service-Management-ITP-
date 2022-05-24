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
    class IncomeDB
    {
        public static string db = "csm";
        public static string tbl2 = "completetable";
        public static string prt = "3306";
        public static string tbl = "mytable";
    
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=" + prt + ";username=root;password=;database=" + db + ";SslMode=none";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddIncome(IncomeFinance incm)
        {
            string sql = "insert into " + tbl + " values (NULL, @incomeCID, @incomeCName, @incomeVID, @incomeTime, @incomeDay, @incomeMonth, @incomeYear, @incomePMethod, @incomePrice)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@incomeCID", MySqlDbType.VarChar).Value = incm.CustomerID;
            cmd.Parameters.Add("@incomeCName", MySqlDbType.VarChar).Value = incm.CustomerName;
            cmd.Parameters.Add("@incomeVID", MySqlDbType.VarChar).Value = incm.VehicleID;
            cmd.Parameters.Add("@incomeTime", MySqlDbType.VarChar).Value = incm.Time;
            cmd.Parameters.Add("@incomeDay", MySqlDbType.VarChar).Value = incm.Day;
            cmd.Parameters.Add("@incomeMonth", MySqlDbType.VarChar).Value = incm.Month;
            cmd.Parameters.Add("@incomeYear", MySqlDbType.VarChar).Value = incm.Year;
            cmd.Parameters.Add("@incomePMethod", MySqlDbType.VarChar).Value = incm.PaymenthM;
            cmd.Parameters.Add("@incomePrice", MySqlDbType.VarChar).Value = incm.Price;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Insertion faild! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        public static void UpdateIncome(IncomeFinance incm, string id)
        {
            string sql = "update " + tbl + " set CustomerID = @incomeCID, CustomerName = @incomeCName, VehicleID = @incomeVID, Time = @incomeTime, Day = @incomeDay, Month = @incomeMonth, Year = @incomeYear, PaymenthM = @incomePMethod, Price = @incomePrice where S_ID = @incomeID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@incomeID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@incomeCID", MySqlDbType.VarChar).Value = incm.CustomerID;
            cmd.Parameters.Add("@incomeCName", MySqlDbType.VarChar).Value = incm.CustomerName;
            cmd.Parameters.Add("@incomeVID", MySqlDbType.VarChar).Value = incm.VehicleID;
            cmd.Parameters.Add("@incomeTime", MySqlDbType.VarChar).Value = incm.Time;
            cmd.Parameters.Add("@incomeDay", MySqlDbType.VarChar).Value = incm.Day;
            cmd.Parameters.Add("@incomeMonth", MySqlDbType.VarChar).Value = incm.Month;
            cmd.Parameters.Add("@incomeYear", MySqlDbType.VarChar).Value = incm.Year;
            cmd.Parameters.Add("@incomePMethod", MySqlDbType.VarChar).Value = incm.PaymenthM;
            cmd.Parameters.Add("@incomePrice", MySqlDbType.VarChar).Value = incm.Price;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Updation faild! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        public static void DeleteIncome(string id)
        {
            string sql = "delete from " + tbl + " where S_ID = @incomeID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@incomeID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Deletion faild! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayIncome(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            adp.Fill(dtbl);
            dgv.DataSource = dtbl;
            con.Close();
        }

        public static int getThisMonthTotalIncome(string im, string iy)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select sum(Price) as 'sum' from " + tbl + " where Month = '" + im + "' and Year = "+iy;
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
            catch(Exception ex)
            {
                
            }

            return 0;
        }

        public static int getAvgPaymentMethods(string pm)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select count(*) as 'count' from " + tbl + " where PaymenthM = '" + pm + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
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

        public static int getAvgPaymentMethodsForMonth(string pm, String m, String y)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select count(*) as 'count' from " + tbl + " where PaymenthM = '" + pm + "' and Month = '" + m + "'  and Year = '" + y + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
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
        
        public static int getTotPaymentsForMonth(string pm, String m, String y)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select sum(Price) as 'sum' from " + tbl + " where PaymenthM = '" + pm + "' and Month = '" + m + "' and Year = '" + y + "'";
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

        public static int getThisDayTotalIncome(string id, string im, string iy)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select sum(Price) as 'sum' from " + tbl + " where Day = '" + id + "' and Month = '" + im + "' and Year = " + iy;
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

        public static String getCustomerCount(String d, String m, String y)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select count(NIC) as 'count' from customertable where Arr_Time LIKE'" + d + "%' and Arr_Month = '" + m + "' and Arr_Year = '" + y + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    return g;
                }

                return "0";
            }
            catch (Exception ex)
            {

            }

            return "0";
        }

        public static String getVehicleCount(String d, String m, String y)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select count(Vehicle_num) as 'count' from customertable where Arr_Time LIKE'" + d + "%' and Arr_Month = '" + m + "' and Arr_Year = '" + y + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    return g;
                }

                return "0";
            }
            catch (Exception ex)
            {

            }

            return "0";
        }

        public static String getTotBooking(string id, string im)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select count(BID) as 'sum' from bookingtb where Day = '" + id + "' and Month = '" + im + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["sum"].ToString();
                    return g;
                }

                return "0";
            }
            catch (Exception ex)
            {

            }

            return "0";
        }

        public static String getCucName(string nic)
        {
            try
            {
                int x;
                string g = "";

                MySqlConnection con = GetConnection();
                string sqlq = "select Customer_Name from " + tbl2 + " where NIC = '" + nic + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    g = dr["Customer_Name"].ToString();
                }
                return g;
            }
            catch (Exception ex)
            {

            }

            return "";
        }

        public static String getCusVehicle(string nic)
        {
            try
            {
                int x;
                string g = "";

                MySqlConnection con = GetConnection();
                string sqlq = "select Vehicle_num from " + tbl2 + " where NIC = '" + nic + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    g = dr["Vehicle_num"].ToString();
                }

                return g;
            }
            catch (Exception ex)
            {

            }

            return "";
        }

        public static String getCusDiscount(string nic)
        {
            try
            {
                int x;
                string g = "";

                MySqlConnection con = GetConnection();
                string sqlq = "select Discount from " + tbl2 + " where NIC = '" + nic + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    g = dr["Discount"].ToString();
                }

                return g;
            }
            catch (Exception ex)
            {

            }

            return "";
        }

        public static void AddIncomeFromBill(string n1, string n2, string n3, string n4, string n5, string n6, string n7, string n8, string n9)
        {
            string sql = "insert into " + tbl + " values (NULL, @incomeCID, @incomeCName, @incomeVID, @incomeTime, @incomeDay, @incomeMonth, @incomeYear, @incomePMethod, @incomePrice)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@incomeCID", MySqlDbType.VarChar).Value = n1;
            cmd.Parameters.Add("@incomeCName", MySqlDbType.VarChar).Value = n2;
            cmd.Parameters.Add("@incomeVID", MySqlDbType.VarChar).Value = n3;
            cmd.Parameters.Add("@incomeTime", MySqlDbType.VarChar).Value = n4;
            cmd.Parameters.Add("@incomeDay", MySqlDbType.VarChar).Value = n5;
            cmd.Parameters.Add("@incomeMonth", MySqlDbType.VarChar).Value = n6;
            cmd.Parameters.Add("@incomeYear", MySqlDbType.VarChar).Value = n7;
            cmd.Parameters.Add("@incomePMethod", MySqlDbType.VarChar).Value = n8;
            cmd.Parameters.Add("@incomePrice", MySqlDbType.VarChar).Value = n9;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Insertion faild! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

    }
}
