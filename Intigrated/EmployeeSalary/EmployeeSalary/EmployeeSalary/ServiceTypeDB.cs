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
    class ServiceTypeDB
    {
        public static string dt = "mytable2";

        public static void UpdateST(SerType st, string id)
        {
            string sql = "update " + dt + " set SType = @sStype, Price = @sPrice where ID = @sID";
            MySqlConnection con = IncomeDB.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@sID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@sStype", MySqlDbType.VarChar).Value = st.SType;
            cmd.Parameters.Add("@sPrice", MySqlDbType.VarChar).Value = st.Price;

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

        public static void displayST(string qr, DataGridView dgv)
        { 
            MySqlConnection con = IncomeDB.GetConnection();
            MySqlCommand cmd = new MySqlCommand(qr, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            adp.Fill(dtbl);
            dgv.DataSource = dtbl;
            con.Close();
        }

        public static int getServicePrice(int id)
        {
            try
            {
                int x;

                MySqlConnection con = IncomeDB.GetConnection();
                string sqlq = "select Price from " + dt + " where ID = " + id+"";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["Price"].ToString();
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
