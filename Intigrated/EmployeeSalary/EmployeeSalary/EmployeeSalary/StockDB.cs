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
    class StockDB
    {
        //set the connection of DB
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
                MessageBox.Show("MySQL connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        //insert in Current
        public static void AddCurrentStockDB(CurrentStockDB std)
          {
              string sql = "INSERT INTO currentstock_table VALUE(NULL,@CurrentItem_Name,@CurrentDate,@CurrentQuantity,@CurrentUnit_Price,@CurrentMin_quantity)";
              MySqlConnection con = GetConnection();
              MySqlCommand cmd = new MySqlCommand(sql, con);
              cmd.CommandType = CommandType.Text;
              
              cmd.Parameters.Add("@CurrentItem_Name", MySqlDbType.VarChar).Value = std.Item_Name;
              cmd.Parameters.Add("@CurrentDate", MySqlDbType.VarChar).Value = std.Date;
              cmd.Parameters.Add("@CurrentQuantity", MySqlDbType.VarChar).Value = std.Quantity;
              cmd.Parameters.Add("@CurrentUnit_Price", MySqlDbType.VarChar).Value = std.Unit_Price;
              cmd.Parameters.Add("@CurrentMin_quantity", MySqlDbType.VarChar).Value = std.Min_quantity;
              try
              {
                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Added sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              catch (MySqlException ex)
              {
                  MessageBox.Show("Insertion is failed. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              con.Close();
          }


        //update in Current
        public static void UpdateCurrentStockDB(CurrentStockDB std, string id)
        {
            string sql = "UPDATE currentstock_table SET Item_Name = @CurrentItem_Name, Date = @CurrentDate, Quantity = @CurrentQuantity, Unit_Price = @CurrentUnit_Price, Min_quantity = @CurrentMin_quantity WHERE Item_Id= @CurrentItem_Id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@@CurrentItem_Id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@CurrentItem_Name", MySqlDbType.VarChar).Value = std.Item_Name;
            cmd.Parameters.Add("@CurrentDate", MySqlDbType.VarChar).Value = std.Date;
            cmd.Parameters.Add("@CurrentQuantity", MySqlDbType.VarChar).Value = std.Quantity;
            cmd.Parameters.Add("@CurrentUnit_Price", MySqlDbType.VarChar).Value = std.Unit_Price;
            cmd.Parameters.Add("@CurrentMin_quantity", MySqlDbType.VarChar).Value = std.Min_quantity;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Updation is failed. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }


        //delete in Current
        public static void DeleteCurrentStockDB(string id)
        {
            string sql = "delete from currentstock_table where Item_Id = @sID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@sID", MySqlDbType.VarChar).Value = id;

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

        //display and search in Current
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



    }
}