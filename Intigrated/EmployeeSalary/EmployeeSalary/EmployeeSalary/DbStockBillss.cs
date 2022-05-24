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
    class DbStockBillss
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
        public static void AddStockB(StockCost std)
        {
            string sql = "INSERT INTO liststockCost VALUES (@StockCostID,@Order_Id,@Item_Id,@Item_Name,@Date,@Req_Quantity,@Unit_Price,@Total_Price)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@StockCostID", MySqlDbType.VarChar).Value = std.StockCostID;
            cmd.Parameters.Add("@Order_Id", MySqlDbType.VarChar).Value = std.Order_Id;
            cmd.Parameters.Add("@Item_Id", MySqlDbType.VarChar).Value = std.Item_Id;
            cmd.Parameters.Add("@Item_Name", MySqlDbType.VarChar).Value = std.Item_Name;
            cmd.Parameters.Add("@Date", MySqlDbType.VarChar).Value = std.Date;
            cmd.Parameters.Add("@Req_Quantity", MySqlDbType.VarChar).Value = std.Req_Quantity;
            cmd.Parameters.Add("@Unit_Price", MySqlDbType.VarChar).Value = std.Unit_Price;
            cmd.Parameters.Add("@Total_Price", MySqlDbType.VarChar).Value = std.Total_Price;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cost not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        //Update
        public static void UpdateStockB(StockCost std, string StockCostID)
        {
            string sql = "UPDATE liststockCost SET StockCostID=@StockCostID, Order_Id = @Order_Id, Item_Id=@Item_Id, Item_Name=@Item_Name,Date=@Date,Req_Quantity=@Req_Quantity,Unit_Price=@Unit_Price,Total_Price=@Total_Price WHERE StockCostID = @StockCostID ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StockCostID", MySqlDbType.Int32).Value = StockCostID;
            cmd.Parameters.Add("@Order_Id", MySqlDbType.VarChar).Value = std.Order_Id;
            cmd.Parameters.Add("@Item_Id", MySqlDbType.VarChar).Value = std.Item_Id;
            cmd.Parameters.Add("@Item_Name", MySqlDbType.VarChar).Value = std.Item_Name;
            cmd.Parameters.Add("@Date", MySqlDbType.VarChar).Value = std.Date;
            cmd.Parameters.Add("@Req_Quantity", MySqlDbType.VarChar).Value = std.Req_Quantity;
            cmd.Parameters.Add("@Unit_Price", MySqlDbType.VarChar).Value = std.Unit_Price;
            cmd.Parameters.Add("@Total_Price", MySqlDbType.VarChar).Value = std.Total_Price;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cost not update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteEmployeeSalary(String StockCostID)
        {
            string sql = "DELETE FROM liststockcost WHERE StockCostID = @StockCostID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StockCostID", MySqlDbType.VarChar).Value = StockCostID;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cost not deleted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}