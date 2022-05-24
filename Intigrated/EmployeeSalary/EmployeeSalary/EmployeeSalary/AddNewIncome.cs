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
    public partial class AddNewIncome : Form
    {
        private readonly IncomeTable _parent;

        string S_ID;

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

        public AddNewIncome(IncomeTable parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void clearText()
        {
            currentTimeTXT.Text = addNewCusIDtxt.Text = addNewCusNametxt.Text = addNewVehIDtxt.Text = addNewDaytxt.Text = addNewMonthtxt.Text = addNewYeartxt.Text = addNewPayMtxt.Text = addNewPricetxt.Text = string.Empty;
        }

        private void AddNewIncome_Load(object sender, EventArgs e)
        {
            addNewSaveBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addNewSaveBtn.Width, addNewSaveBtn.Height, 10, 10));
            addNewPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addNewPanel.Width, addNewPanel.Height, 20, 20));
        }

        public void updateIncome(string a10, string a1, string a2, string a3, string a9, string a4, string a5, string a6, string a7, string a8)
        {
            headerTxt.Text = "Update";
            addNewSaveBtn.Text = "Update";
            S_ID = a10;
            addNewCusIDtxt.Text = a1;
            addNewCusNametxt.Text = a2;
            addNewVehIDtxt.Text = a3;
            currentTimeTXT.Text = a9;
            addNewDaytxt.Text = a4;
            addNewMonthtxt.Text = a5;
            addNewYeartxt.Text = a6;
            addNewPayMtxt.Text = a7;
            addNewPricetxt.Text = a8;

        }

        public void saveIncome()
        {
            headerTxt.Text = "Add new";
            addNewSaveBtn.Text = "Save";
        }

        private void addNewSaveBtn_Click(object sender, EventArgs e)
        {
            addNewCusIDtxt.BackColor = Color.Gainsboro;
            addNewCusNametxt.BackColor = Color.Gainsboro;
            addNewVehIDtxt.BackColor = Color.Gainsboro;
            addNewDaytxt.BackColor = Color.Gainsboro;
            addNewMonthtxt.BackColor = Color.Gainsboro;
            addNewYeartxt.BackColor = Color.Gainsboro;
            addNewPayMtxt.BackColor = Color.Gainsboro;
            addNewPricetxt.BackColor = Color.Gainsboro;
            currentTimeTXT.BackColor = Color.Gainsboro;

            if (addNewCusIDtxt.Text.Trim().Length < 1)
            {
                statusPanel.BackColor = Color.Red;
                status.BackColor = Color.Red;
                status.Text = "Please enter a valid Customer ID";
                addNewCusIDtxt.BackColor = Color.LightPink;
                return;
            }

            int check = addNewCusIDtxt.Text.Length;
            String nic = addNewCusIDtxt.Text;

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

            if (addNewCusNametxt.Text.Trim().Length < 1)
            {
                statusPanel.BackColor = Color.Red;
                status.BackColor = Color.Red;
                status.Text = "Please enter a valid Customer Name";
                addNewCusNametxt.BackColor = Color.LightPink;
                return;
            }
            if (addNewVehIDtxt.Text.Trim().Length < 1)
            {
                statusPanel.BackColor = Color.Red;
                status.BackColor = Color.Red;
                status.Text = "Please enter a valid Vehicle ID";
                addNewVehIDtxt.BackColor = Color.LightPink;
                return;
            }
            if (addNewDaytxt.Text.Trim().Length < 1)
            {
                statusPanel.BackColor = Color.Red;
                status.BackColor = Color.Red;
                status.Text = "Please enter a valid Day";
                addNewDaytxt.BackColor = Color.LightPink;
                return;
            }
            if (addNewMonthtxt.Text.Trim().Length < 1)
            {
                statusPanel.BackColor = Color.Red;
                status.BackColor = Color.Red;
                status.Text = "Please enter a valid Month";
                addNewMonthtxt.BackColor = Color.LightPink;
                return;
            }
            if (addNewYeartxt.Text.Trim().Length < 1)
            {
                statusPanel.BackColor = Color.Red;
                status.BackColor = Color.Red;
                status.Text = "Please enter a valid Year";
                addNewYeartxt.BackColor = Color.LightPink;
                return;
            }
            if (addNewPayMtxt.Text.Trim().Length < 1)
            {
                statusPanel.BackColor = Color.Red;
                status.BackColor = Color.Red;
                status.Text = "Please enter a valid Payment Method";
                addNewPayMtxt.BackColor = Color.LightPink;
                return;
            }
            if (addNewPricetxt.Text.Trim().Length < 1)
            {
                
                statusPanel.BackColor = Color.Red;
                status.BackColor = Color.Red;
                status.Text = "Please enter a valid Price";
                addNewPricetxt.BackColor = Color.LightPink;
                return;
                
            }
            if (checkLetters(addNewPricetxt.Text))
            {
                MessageBox.Show("Do not enter letters or any other symbols to the price field!!!");
                return;
            }
            if(currentTimeTXT.Text == string.Empty)
            {
                statusPanel.BackColor = Color.Red;
                status.BackColor = Color.Red;
                status.Text = "Please enter a valid Time";
                currentTimeTXT.BackColor = Color.LightPink;
                return;
            }
            if (addNewSaveBtn.Text == "Save")
            {
                statusPanel.BackColor = Color.White;
                status.BackColor = Color.White;
                IncomeFinance incm = new IncomeFinance(addNewCusIDtxt.Text.Trim(), addNewCusNametxt.Text.Trim(), addNewVehIDtxt.Text.Trim(), currentTimeTXT.Text.Trim(), addNewDaytxt.Text.Trim(), addNewMonthtxt.Text.Trim(), addNewYeartxt.Text.Trim(), addNewPayMtxt.Text.Trim(), addNewPricetxt.Text.Trim());
                IncomeDB.AddIncome(incm);
                clearText();
            }
            if (addNewSaveBtn.Text == "Update")
            {
                statusPanel.BackColor = Color.White;
                status.BackColor = Color.White;
                IncomeFinance incm = new IncomeFinance(addNewCusIDtxt.Text.Trim(), addNewCusNametxt.Text.Trim(), addNewVehIDtxt.Text.Trim(), currentTimeTXT.Text.Trim(), addNewDaytxt.Text.Trim(), addNewMonthtxt.Text.Trim(), addNewYeartxt.Text.Trim(), addNewPayMtxt.Text.Trim(), addNewPricetxt.Text.Trim());
                IncomeDB.UpdateIncome(incm, S_ID);
                Close();
            }
            _parent.displayGrid();
           
        }

        private void getTime_Click(object sender, EventArgs e)
        {
            currentTimeTXT.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString();
        }

        public void setDate()
        {
            string monthNo = DateTime.Now.Month.ToString();
            String monthName = "";
            int monthN = Convert.ToInt32(monthNo);

            if (monthN == 1)
                monthName = "January";
            else if (monthN == 2)
                monthName = "February";
            else if (monthN == 3)
                monthName = "March";
            else if (monthN == 4)
                monthName = "April";
            else if (monthN == 5)
                monthName = "May";
            else if (monthN == 6)
                monthName = "June";
            else if (monthN == 7)
                monthName = "July";
            else if (monthN == 8)
                monthName = "August";
            else if (monthN == 9)
                monthName = "September";
            else if (monthN == 10)
                monthName = "Octorber";
            else if (monthN == 11)
                monthName = "November";
            else if (monthN == 12)
                monthName = "December";
            else
                monthName = "Not found";

            addNewMonthtxt.Text = monthName;
            addNewYeartxt.Text = DateTime.Now.Year.ToString();
            addNewDaytxt.Text = DateTime.Now.Day.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool checkLetters(string l)
        {
            try
            {
                Convert.ToInt32(l);
            }
            catch (Exception ex)
            {
                
                return true;
            }

            return false;

        }

        private void getDate_Click(object sender, EventArgs e)
        {
            setDate();
        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
