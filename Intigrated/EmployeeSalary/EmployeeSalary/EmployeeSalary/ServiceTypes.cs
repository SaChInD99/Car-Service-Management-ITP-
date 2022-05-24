using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class ServiceTypes : Form
    {

        private readonly Bill _parent;
        string id;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nwidthEllipse,
                int nHightEllipse
            );

        public ServiceTypes(Bill parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _parent.prices();
            _parent.Clear();
            Close();
        }

        private void ServiceTypes_Load(object sender, EventArgs e)
        {
            serviceTypeSaveBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, serviceTypeSaveBtn.Width, serviceTypeSaveBtn.Height, 5, 5));
            STedit.ReadOnly = true;
        }

        public void UpdateSType(string pid, string sType, string price)
        {
            STedit.Text = sType;
            SPedit.Text = price;
            id = pid;
        }

        public void displaySTdata()
        {
            ServiceTypeDB.displayST("select ID, SType, Price from "+ServiceTypeDB.dt+"", STdataGrid);
        }

        public void clear()
        {
            STedit.Text = SPedit.Text = string.Empty;
        }

        private void serviceTypeSaveBtn_Click(object sender, EventArgs e)
        {
            if(STedit.Text == string.Empty)
            {
                field1status.Text = "Get the data from the table";
                return;
            }
            if(SPedit.Text == string.Empty)
            {
                field1status.Text = "";
                field2status.Text = "This field can not be empty!";
                return;
            }

            SerType st = new SerType(STedit.Text, SPedit.Text);
            ServiceTypeDB.UpdateST(st, id);
            clear();
            field2status.Text = "";
            displaySTdata();
        }

        private void ServiceTypes_Shown(object sender, EventArgs e)
        {
            displaySTdata();
        }

        private void searchST_TextChanged(object sender, EventArgs e)
        {
            ServiceTypeDB.displayST("select ID, SType, Price from " + ServiceTypeDB.dt + " where SType like '%" + searchST.Text+ "%'", STdataGrid);
        }

        private void STdataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this.clear();
                string id1 = STdataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                string s1 = STdataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string p1 = STdataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

                this.UpdateSType(id1, s1, p1);
            }


        }
    }
}
