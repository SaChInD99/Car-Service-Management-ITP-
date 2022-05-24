using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suppliermanage
{
    class dbsupplier
    {
        
        public static MySqlConnection GetConnection()
        {
            string db = "csm";
            string sql = "datasource=localhost;port=3306;username=root;password=;database=" + db + ";SslMode=none";
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
        public static void AddSupplier(supplier supd)
        {
            //string a1 = DateTime.Now.Day.ToString();
            //string a2 = DateTime.Now.Month.ToString();
            //string a3 = DateTime.Now.Year.ToString();
            //string date = a1 + " / " + a2 + " / " + a3;
            string sql = "INSERT INTO suppliermanage VALUES (NULL ,@companyname, @address, @country, @contactnumber, @email, @ListItem_Id, @itemtype, @description, @date )";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@companyname", MySqlDbType.VarChar).Value = supd.CompanyName; ;//
            cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = supd.Address;//supd.Address;
            cmd.Parameters.Add("@country", MySqlDbType.VarChar).Value = supd.Country; ;//supd.Country;
            cmd.Parameters.Add("@contactnumber", MySqlDbType.VarChar).Value = supd.ContactNumber; ; //supd.ContactNumber;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = supd.Email; ;//supd.Email;
            cmd.Parameters.Add("@ListItem_Id", MySqlDbType.VarChar).Value = supd.Item_Id; ; //supd.PaymentType;
            cmd.Parameters.Add("@itemtype", MySqlDbType.VarChar).Value = supd.ItemType; ;//supd.ItemType;
            cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = supd.Description; ; //supd.Description;
            cmd.Parameters.Add("@date", MySqlDbType.VarChar).Value = supd.Date;//supd.Date;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(" New Supplier Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(MySqlException ex)
            {
                MessageBox.Show("Supplier not insert.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            con.Close();
        }

        public static void UpdateSupplire(supplier supd, string id)
        {
            string sql = "update suppliermanage set companyname = @companyname, address = @address, country = @country, contactnumber = @contactnumber, email = @email, Item_Id = @ListItem_Id, itemtype = @itemtype, description = @description, date = @date where sup_id = @sup_id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@sup_id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@companyname", MySqlDbType.VarChar).Value = supd.CompanyName;
            cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = supd.Address;
            cmd.Parameters.Add("@country", MySqlDbType.VarChar).Value = supd.Country;
            cmd.Parameters.Add("@contactnumber", MySqlDbType.VarChar).Value = supd.ContactNumber;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = supd.Email;
            cmd.Parameters.Add("@ListItem_Id", MySqlDbType.VarChar).Value = supd.Item_Id;
            cmd.Parameters.Add("@itemtype", MySqlDbType.VarChar).Value = supd.ItemType;
            cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = supd.Description;
            cmd.Parameters.Add("@date", MySqlDbType.VarChar).Value = supd.Date;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Details Updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Updation faild! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
        public static void DeleteSupplier(string id)
        {
           string sql = "delete from suppliermanage where sup_id = @sup_id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@sup_id", MySqlDbType.VarChar).Value = id;

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

        public static void DisplaySupplier(string query, DataGridView dgv)
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
    }
    
}
