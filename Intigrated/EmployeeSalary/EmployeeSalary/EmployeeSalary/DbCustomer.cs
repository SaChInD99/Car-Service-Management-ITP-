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
    class DbCustomer
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=csm;sslmode=None";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddCustomer(Customer cus)
        {
            string sql = "INSERT INTO customertable VALUES(null,@Cusarr_Year, @Cusarr_Month, @Cusarr_Time, @CusbID, @CusnIC, @Cuscustomer_Name, @Cusaddress, @Cusemail, @Cuscontact_No, @Cusvehicle_num)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType =  CommandType.Text;

            cmd.Parameters.Add("@Cusarr_Year", MySqlDbType.VarChar).Value = cus.Arr_Year;
            cmd.Parameters.Add("@Cusarr_Month", MySqlDbType.VarChar).Value = cus.Arr_Month;
            cmd.Parameters.Add("@Cusarr_Time", MySqlDbType.VarChar).Value = cus.Arr_Time;
            cmd.Parameters.Add("@CusbID", MySqlDbType.VarChar).Value = cus.BID;
            cmd.Parameters.Add("@CusnIC", MySqlDbType.VarChar).Value = cus.NIC;
            cmd.Parameters.Add("@Cuscustomer_Name", MySqlDbType.VarChar).Value = cus.Customer_Name;
            cmd.Parameters.Add("@Cusaddress", MySqlDbType.VarChar).Value = cus.Address;
            cmd.Parameters.Add("@Cusemail", MySqlDbType.VarChar).Value = cus.Email;
            cmd.Parameters.Add("@Cuscontact_No", MySqlDbType.VarChar).Value = cus.Contact_No;
            cmd.Parameters.Add("@Cusvehicle_num", MySqlDbType.VarChar).Value = cus.Vehicle_num;
           


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Customer Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex) 
            {
                MessageBox.Show("Customer Not Inserted!!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        public static void UpdateCustomer(Customer cus,string id)
        {
            string sql = "UPDATE customertable SET S_Code = @Cuscode, Arr_Year = @Cusarr_Year, Arr_Month = @Cusarr_Month, Arr_Time = @Cusarr_Time, BID = @CusbID, NIC = @CusnIC, Customer_Name = @Cuscustomer_Name, Address = @Cusaddress, Email=@Cusemail,Contact_No = @Cuscontact_No, Vehicle_num = @Cusvehicle_num WHERE S_Code = @cuscode";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@cuscode", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@Cusarr_Year", MySqlDbType.VarChar).Value = cus.Arr_Year;
            cmd.Parameters.Add("@Cusarr_Month", MySqlDbType.VarChar).Value = cus.Arr_Month;
            cmd.Parameters.Add("@Cusarr_Time", MySqlDbType.VarChar).Value = cus.Arr_Time;
            cmd.Parameters.Add("@CusbID", MySqlDbType.VarChar).Value = cus.BID;
            cmd.Parameters.Add("@CusnIC", MySqlDbType.VarChar).Value = cus.NIC;
            cmd.Parameters.Add("@Cuscustomer_Name", MySqlDbType.VarChar).Value = cus.Customer_Name;
            cmd.Parameters.Add("@Cusaddress", MySqlDbType.VarChar).Value = cus.Address;
            cmd.Parameters.Add("@Cusemail", MySqlDbType.VarChar).Value = cus.Email;
            cmd.Parameters.Add("@Cuscontact_No", MySqlDbType.VarChar).Value = cus.Contact_No;
            cmd.Parameters.Add("@Cusvehicle_num", MySqlDbType.VarChar).Value = cus.Vehicle_num;
           

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Customer Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Customer Not Updated!!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        public static void DeleteCustomer(string id)
        {
            string sql = "DELETE FROM customertable WHERE S_Code = @cuscode";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@cuscode", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Customer Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Customer Not Updated!!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }



        public static void DisplayAndSearch(String query, DataGridView dgv)
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

        
        public static void ConfirmCustomer(Complete com)
        {
            string sql = "INSERT INTO completetable VALUES(null,@ComS_Code, @ComNIC, @ComCustomer_Name, @ComVehicle_num, @ComCom_Year , @ComCom_Month,@ComCom_Time, @ComService_count, @ComDiscount, @ComService_Regards)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ComS_Code", MySqlDbType.VarChar).Value = com.S_Code;
            cmd.Parameters.Add("@ComNIC", MySqlDbType.VarChar).Value = com.NIC;
            cmd.Parameters.Add("@ComCustomer_Name", MySqlDbType.VarChar).Value = com.Customer_Name;
            cmd.Parameters.Add("@ComVehicle_num", MySqlDbType.VarChar).Value = com.Vehicle_num;
            cmd.Parameters.Add("@ComCom_Year", MySqlDbType.VarChar).Value = com.Com_Year;
            cmd.Parameters.Add("@ComCom_Month", MySqlDbType.VarChar).Value = com.Com_Month;
            cmd.Parameters.Add("@ComCom_Time", MySqlDbType.VarChar).Value = com.Com_Time;
            cmd.Parameters.Add("@ComService_count", MySqlDbType.VarChar).Value = com.Service_count;
            cmd.Parameters.Add("@ComDiscount", MySqlDbType.VarChar).Value = com.Discount;
            cmd.Parameters.Add("@ComService_Regards", MySqlDbType.VarChar).Value = com.Service_Regards;
          



            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Service Confirmation Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Customer Not Confirmed!!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        public static void DeleteService(string ccode)
        {
            string sql = "DELETE FROM completetable WHERE C_Index = @comindex";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@comindex", MySqlDbType.VarChar).Value = ccode;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Customer Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Customer Not Updated!!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static string getCusDetails(string clmn, string id)
        {
            try
            {
                
                MySqlConnection con = GetConnection();
                string sqlq = "select "+clmn+" from customertable where NIC = '" + id + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string x = dr[clmn].ToString();
                    return x;
                }

                return "";
            }
            catch (Exception ex)
            {

            }

            return "";
        }

        public static int getCount(string y, string id)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select count(*) as 'count' from completetable where Vehicle_num = '" + id + "' and Com_Year = '" + y + "' ";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    x = Convert.ToInt32(g);
                    return x+1;
                }

                return 0;
            }
            catch (Exception ex)
            {

            }

            return 0;
        }

        public static int CustomerCount()
        {
            try
            {
                int y;

                MySqlConnection con = GetConnection();
                string sqlc = "select count(*) as 'count' from customertable ";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlc;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    y = Convert.ToInt32(g);
                    return y;
                }

                return 0;
            }
            catch (Exception ex)
            {

            }

            return 0;
        }

        public static int graphCount(string m, string d)
        {
            try
            {
                int p;

                MySqlConnection con = GetConnection();
                string sqlx = "select count(*) as 'count' from customertable where Arr_Time LIKE'" + d + "%' and Arr_Month = '" + m + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlx;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    p = Convert.ToInt32(g);
                    return p;
                }

                return 0;
            }
            catch (Exception ex)
            {

            }

            return 0;
        }

        public static int DiscountCount()
        {
            try
            {
                int y;

                MySqlConnection con = GetConnection();
                string sqlc = "select count(*) as 'count' from completetable where Discount= 'Yes'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlc;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    y = Convert.ToInt32(g);
                    return y;
                }

                return 0;
            }
            catch (Exception ex)
            {

            }

            return 0;
        }

        public static int completecount()
        {
            try
            {
                int e;

                MySqlConnection con = GetConnection();
                string sqle = "select count(*) as 'count' from completetable";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqle;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    e = Convert.ToInt32(g);
                    return e;
                }

                return 0;
            }
            catch (Exception ex)
            {

            }

            return 0;
        }

        public static int nonBookedCusCount()
        {
            try
            {
                int b;

                MySqlConnection con = GetConnection();
                string sqlb = "select count(*) as 'count' from customertable where BID='none'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlb;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    b = Convert.ToInt32(g);
                    return b;
                }

                return 0;
            }
            catch (Exception ex)
            {

            }

            return 0;
        }

        public static int getCustomerCountForMonth(String d, String m)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select count(*) as 'count' from customertable where Arr_Time LIKE'" + d + "%' and Arr_Month = '" + m + "'";
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

        public static int pieCount(string y,string dis)
        {
            try
            {
                int n;

                MySqlConnection con = GetConnection();
                string sqln = "select count(*) as 'count' from completetable where Discount = '" + dis + "' and Com_Year = '" + y + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqln;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    n = Convert.ToInt32(g);
                    return n;
                }

                return 0;
            }
            catch (Exception ex)
            {

            }

            return 0;
        }

        public static int MonthCustomerCount(string mon)
        {
            try
            {
                int y;

                MySqlConnection con = GetConnection();
                string sqlc = "select count(*) as 'count' from customertable where Arr_Month = '" + mon + "' ";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlc;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    y = Convert.ToInt32(g);
                    return y;
                }

                return 0;
            }
            catch (Exception ex)
            {

            }

            return 0;
        }

        public static int MonthnonBookedCusCount(string mon)
        {
            try
            {
                int l;

                MySqlConnection con = GetConnection();
                string sqlb = "select count(*) as 'count' from customertable where Arr_Month = '" + mon + "' and BID = 'none'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlb;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    l = Convert.ToInt32(g);
                    return l;
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
