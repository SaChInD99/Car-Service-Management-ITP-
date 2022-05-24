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
    class ListStockDB
    {
        //insert in List
        public static void AddListStock(ListStock std)
        {
            string sql = "INSERT INTO liststock_table VALUE(NULL,@ListItem_Id,@ListItem_Name,@ListDate,@ListReq_Quantity,@ListUnit_Price,@ListTotal_Price)";
            MySqlConnection con = StockDB.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ListItem_Id", MySqlDbType.VarChar).Value = std.Item_Id;
            cmd.Parameters.Add("@ListItem_Name", MySqlDbType.VarChar).Value = std.Item_Name;
            cmd.Parameters.Add("@ListDate", MySqlDbType.VarChar).Value = std.Date;
            cmd.Parameters.Add("@ListReq_Quantity", MySqlDbType.VarChar).Value = std.Req_Quantity;
            cmd.Parameters.Add("@ListUnit_Price", MySqlDbType.VarChar).Value = std.Unit_Price;
            cmd.Parameters.Add("@ListTotal_Price", MySqlDbType.VarChar).Value = std.Total_Price;
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

        //update in List
        /*public static void UpdateListStock(ListStock std, string id)
        {
            string sql = "UPDATE liststock_table SET Item_Id = @ListItem_Id, Item_Name = ,@ListItem_Name, Date = @ListDate, Req_Quantity = @ListReq_Quantity, Unit_Price = @ListUnit_Price, Total_Price = @ListTotal_Price WHERE Order_Id= @ListOrder_Id";
            MySqlConnection con = StockDB.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ListOrder_Id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ListItem_Id", MySqlDbType.VarChar).Value = std.Item_Id;
            cmd.Parameters.Add("@ListItem_Name", MySqlDbType.VarChar).Value = std.Item_Name;
            cmd.Parameters.Add("@ListDate", MySqlDbType.VarChar).Value = std.Date;
            cmd.Parameters.Add("@ListReq_Quantity", MySqlDbType.VarChar).Value = std.Req_Quantity;
            cmd.Parameters.Add("@ListUnit_Price", MySqlDbType.VarChar).Value = std.Unit_Price;
            cmd.Parameters.Add("@ListTotal_Price", MySqlDbType.VarChar).Value = std.Total_Price;
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
        */

        //delete in List
        public static void DeleteListStock(string id)
        {
            string sql = "delete from liststock_table where Order_Id= @ListOrder_Id";
            MySqlConnection con = StockDB.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ListOrder_Id", MySqlDbType.VarChar).Value = id;

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

        public static string getThisMonthTotalStockOutgoing(string mm, string yy)
        {
            try
            {
                int x;

                MySqlConnection con = StockDB.GetConnection();
                string sqlq = "select sum(Total_Price) as 'sum' from liststock_table where Date LIKE'%" + yy + " / " + mm + " /%'";// and Year(Date)  = " + yy;
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

        //display and search in List b
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = StockDB.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();

        }

    }
}
