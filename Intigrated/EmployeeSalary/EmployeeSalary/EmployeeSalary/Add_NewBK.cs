using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class Add_NewBK : Form
    {
        private readonly BK_Main _parent;
        string BID;

        //fix rectangle curves
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
        public Add_NewBK(BK_Main parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        //update EmployeeSalary
        public void Update(string n1, string n2, string n3, string n4, string n5, string n6, string n7, string n8, string n9, string n10)
        {

            btnSubmit.Text = "Update";
            BID = n1;
            txtC_Name.Text = n2;
            txtContact_No.Text = n3;
            txtVehicle_No.Text = n4;
            txtNIC.Text = n5;
            txtB_Type.Text = n6;
            txtTime.Text = n7;
            txtDay.Text = n8;
            txtMonth.Text = n9;
            txtService_Slot1.Text = n10;
        }

        public void AddInfo()
        {

            btnSubmit.Text = "Submit";
        }
        public void Clear()
        {

            txtMonth.Text = txtB_Type.Text = txtC_Name.Text = txtContact_No.Text = txtVehicle_No.Text = txtNIC.Text = txtB_Type.Text = txtTime.Text = txtDay.Text = txtMonth.Text = txtService_Slot1.Text = string.Empty;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //fix rectangle curves
            btnReset.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnReset.Width, btnReset.Height, 15, 15));
            btnSubmit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSubmit.Width, btnSubmit.Height, 15, 15));
            btnServiceSlot.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnServiceSlot.Width, btnServiceSlot.Height, 15, 15));
        }

        //close Button
        private void button4_Click(object sender, EventArgs e)
        {
            // DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (dialog == DialogResult.Yes)
            {
                Close();
            }//
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //insert
        private void button2_Click(object sender, EventArgs e)
        {
            statusBox.BackColor = Color.Gainsboro;
            statusBox.Text = "";


            if (txtC_Name.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "C_Name is Empty";
                return;
            }
            if (txtContact_No.Text.Trim().Length < 10)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "Please Enter 10 Digit Contact Number";
                return;
            }
            if (txtVehicle_No.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "Vehicle_No is Empty ";
                return;
            }
            if (txtNIC.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "NIC is Empty ";
                return;
            }
            int check = txtNIC.Text.Length;
            String nic = txtNIC.Text;

            if ((check == 10) || (check == 12))
            {
                if (check == 10)
                {
                    for (int i = 0; i < check - 1; i++)
                    {
                        try
                        {
                            int temp = Convert.ToInt32(Convert.ToString(nic[i]));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There Cannot be characters in the middle of the NIC");
                            return;
                        }
                    }

                    if (!(nic[check - 1] == 'v' || nic[check - 1] == 'V'))
                    {
                        MessageBox.Show("Invalid NIC");
                        return;
                    }
                }

                if (check == 12)
                {
                    for (int i = 0; i < check; i++)
                    {
                        try
                        {
                            int temp = Convert.ToInt32(Convert.ToString(nic[i]));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There Cannot be characters in the middle of the NIC");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid NIC");
                return;
            }
            if (txtB_Type.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "B_Type is Empty ";
                return;
            }
           
            if (txtMonth.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "Month is Empty ";
                return;
            }
            if (txtDay.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "Day is Empty ";
                return;
            }
            if (txtTime.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "Time is Empty ";
                return;
            }
            if (txtService_Slot1.Text.Trim().Length < 1)
            {
                statusBox.BackColor = Color.Red;
                statusBox.Text = "Service slot is Empty ";
                return;
            }
            if (btnSubmit.Text == "Submit")
            {
                booking bk = new booking(txtC_Name.Text.Trim(), txtContact_No.Text.Trim(), txtVehicle_No.Text.Trim(), txtNIC.Text.Trim(), txtB_Type.Text.Trim(), txtTime.Text.Trim(), txtDay.Text.Trim(), txtMonth.Text.Trim(), txtService_Slot1.Text.Trim());
                bookingtb.Addbooking(bk);
                Clear();
                Close();
            }
            if (btnSubmit.Text == "Update")
            {
                booking bk = new booking(txtC_Name.Text.Trim(), txtContact_No.Text.Trim(), txtVehicle_No.Text.Trim(), txtNIC.Text.Trim(), txtB_Type.Text.Trim(), txtTime.Text.Trim(), txtDay.Text.Trim(), txtMonth.Text.Trim(), txtService_Slot1.Text.Trim());
                bookingtb.Updatebooking(bk, BID);
                Close();
            }
            _parent.Display();

        }




        private void button3_Click(object sender, EventArgs e)
        {
            new Available_SlotBK().ShowDialog();
        }

        private void txtC_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtContact_No_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtContact_No_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Add_NewBK_Load(object sender, EventArgs e)
        {
            //fix rectangle curves
            btnReset.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnReset.Width, btnReset.Height, 15, 15));
            btnSubmit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSubmit.Width, btnSubmit.Height, 15, 15));
            btnServiceSlot.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnServiceSlot.Width, btnServiceSlot.Height, 15, 15));
        }
    }

}
