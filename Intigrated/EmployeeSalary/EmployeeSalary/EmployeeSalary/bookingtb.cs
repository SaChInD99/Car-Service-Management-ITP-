using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalary
{
    class bookingtb
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
                MessageBox.Show("MySql connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public static void Addbooking(booking bk)
        {
            string sql = "INSERT INTO bookingtb VALUES (NULL, @CustomerName, @ContactNumber, @VehicalNumber, @NIC, @BookingType, @Time, @Day, @Month, @ServiceSlot )";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@CustomerName", MySqlDbType.VarChar).Value = bk.C_Name;
            cmd.Parameters.Add("@ContactNumber", MySqlDbType.VarChar).Value = bk.Contact_No;
            cmd.Parameters.Add("@VehicalNumber", MySqlDbType.VarChar).Value = bk.Vehicle_No;
            cmd.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = bk.NIC;
            cmd.Parameters.Add("@BookingType", MySqlDbType.VarChar).Value = bk.B_Type;
            cmd.Parameters.Add("@Time", MySqlDbType.VarChar).Value = bk.Time;
            cmd.Parameters.Add("@Day", MySqlDbType.VarChar).Value = bk.Day;
            cmd.Parameters.Add("@Month", MySqlDbType.VarChar).Value = bk.Month;
            cmd.Parameters.Add("@ServiceSlot", MySqlDbType.VarChar).Value = bk.Service_Slot;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not insert \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Updatebooking(booking bk, String id)
        {
            string sql = "UPDATE bookingtb SET C_Name = @CustomerName, Contact_No = @ContactNumber, Vehicle_No = @VehicalNumber, NIC = @NIC, B_Type = @BookingType, Time = @Time, Day = @Day, Month = @Month, Service_Slot = @ServiceSlot WHERE BID = @Bid ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@Bid", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@CustomerName", MySqlDbType.VarChar).Value = bk.C_Name;
            cmd.Parameters.Add("@ContactNumber", MySqlDbType.VarChar).Value = bk.Contact_No;
            cmd.Parameters.Add("@VehicalNumber", MySqlDbType.VarChar).Value = bk.Vehicle_No;
            cmd.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = bk.NIC;
            cmd.Parameters.Add("@BookingType", MySqlDbType.VarChar).Value = bk.B_Type;
            cmd.Parameters.Add("@Time", MySqlDbType.VarChar).Value = bk.Time;
            cmd.Parameters.Add("@Day", MySqlDbType.VarChar).Value = bk.Day;
            cmd.Parameters.Add("@Month", MySqlDbType.VarChar).Value = bk.Month;
            cmd.Parameters.Add("@ServiceSlot", MySqlDbType.VarChar).Value = bk.Service_Slot;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not update \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Deletebooking(string id)
        {
            string sql = "DELETE FROM bookingtb WHERE BID = @BID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@BID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not delete \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static string getServiceSlot(string t)
        {
            try
            {
                
                MySqlConnection con = GetConnection();
                string sqlq = "select Service_Slot from bookingtb where Time like '%" + t + "%'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["Service_Slot"].ToString();
                    return g;
                }

                return "read failed";
            }
            catch (Exception ex)
            {

            }

            return "failed";
        }

        public static int getBookingCountForMonth(String d,String m)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select count(*) as 'count' from bookingtb where Month = '" + m + "' and Day = '" + d + "'";
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
        
        public static String getChartDetails(String bt, String m)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "SELECT count(B_Type) as 'count' FROM bookingtb where B_Type = '"+bt+ "' and Month = '"+m+"'";
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

        public static void AddCustomer(String f1, String f2, String f3, String f4, String f5, String f6, String f7, String f8, String f9, String f10)
        {
            string sql = "INSERT INTO customertable VALUES(null,@Cusarr_Year, @Cusarr_Month, @Cusarr_Time, @CusbID, @CusnIC, @Cuscustomer_Name, @Cusaddress, @Cusemail, @Cuscontact_No, @Cusvehicle_num)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Cusarr_Year", MySqlDbType.VarChar).Value = f1;
            cmd.Parameters.Add("@Cusarr_Month", MySqlDbType.VarChar).Value = f2;
            cmd.Parameters.Add("@Cusarr_Time", MySqlDbType.VarChar).Value = f3;
            cmd.Parameters.Add("@CusbID", MySqlDbType.VarChar).Value = f4;
            cmd.Parameters.Add("@CusnIC", MySqlDbType.VarChar).Value = f5;
            cmd.Parameters.Add("@Cuscustomer_Name", MySqlDbType.VarChar).Value = f6;
            cmd.Parameters.Add("@Cusaddress", MySqlDbType.VarChar).Value = f7;
            cmd.Parameters.Add("@Cusemail", MySqlDbType.VarChar).Value = f8;
            cmd.Parameters.Add("@Cuscontact_No", MySqlDbType.VarChar).Value = f9;
            cmd.Parameters.Add("@Cusvehicle_num", MySqlDbType.VarChar).Value = f10;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Customer Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Customer Not Inserted!!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        public static String getTotBooking(string im)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select count(BID) as 'sum' from bookingtb where Month = '" + im + "'";
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
    }
    
}
