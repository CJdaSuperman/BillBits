using BillOrganizer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillOrganizer
{
    public partial class BillEditForm : Form
    {
        Bills billsForm;

        public BillEditForm()
        {
            InitializeComponent();
            DisplayBill();
        }

        public BillEditForm(Bills parent)
        {
            InitializeComponent();
            DisplayBill();
            billsForm = parent;
        }

        private void DisplayBill()
        {
            txtName.Text = GlobalBillLists.billList[GlobalBillLists.billListIndex].Name;
            txtDueDate.Text = GlobalBillLists.billList[GlobalBillLists.billListIndex].DueDate;
            txtBalance.Text = Convert.ToString(GlobalBillLists.billList[GlobalBillLists.billListIndex].Balance);
            txtMinDue.Text = Convert.ToString(GlobalBillLists.billList[GlobalBillLists.billListIndex].MinDue);

            for(int i = 0; i < GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments.Length; i++)
            {
                if(GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[i].Date != null)
                {
                    switch (i)
                    {
                        case 0:
                            txt1MonthAgoDate.Text = GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[i].Date;
                            txt1MonthAgoPaid.Text = Convert.ToString(GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[i].paidAmount);
                            break;
                        case 1:
                            txt2MonthsAgoDate.Text = GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[i].Date;
                            txt2MonthsAgoPaid.Text = Convert.ToString(GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[i].paidAmount);
                            break;
                        case 2:
                            txt3MonthsAgoDate.Text = GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[i].Date;
                            txt3MonthsAgoPaid.Text = Convert.ToString(GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[i].paidAmount);
                            break;
                    }
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                AssignBill();

                GlobalConfig.Connection.UpdateEdit();

                GlobalBillLists.OrganizeBillList();

                billsForm.WireList();

                this.Close();
            }
        }

        bool ValidateForm()
        {
            if (txtName.Text.Length == 0 ||
                txtBalance.Text.Length == 0 ||
                txtMinDue.Text.Length == 0)
            {
                MessageBox.Show("All fields need to be entered.", "Invalid Entry",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal balanceResult, minDueResult;
            bool balanceAcceptable = Decimal.TryParse(txtBalance.Text, out balanceResult);
            bool minDueAcceptable = Decimal.TryParse(txtMinDue.Text, out minDueResult);

            decimal previousMonthPaidResult, twoMonthsPaidResult, threeMonthsPaidResult;
            bool previousMonthPaidAcceptable = Decimal.TryParse(txt1MonthAgoPaid.Text, out previousMonthPaidResult);
            bool twoMonthsPaidAcceptable = Decimal.TryParse(txt2MonthsAgoPaid.Text, out twoMonthsPaidResult);
            bool threeMonthsPaidAcceptable = Decimal.TryParse(txt3MonthsAgoPaid.Text, out threeMonthsPaidResult);

            if (!balanceAcceptable)
            {
                MessageBox.Show("Enter in a correct number for the balance, without dollar sign.", 
                    "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if(!minDueAcceptable)
            {
                MessageBox.Show("Enter in a correct number for the minimum due, without dollar sign.", 
                    "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!previousMonthPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for the 1 Month Ago Paid, without dollar sign.",
                    "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!twoMonthsPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for the 2 Months Ago Paid, without dollar sign.",
                    "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!threeMonthsPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for the 3 Months Ago Paid, without dollar sign.",
                    "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if(!balanceAcceptable && minDueAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the balance and the minimum due, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!balanceAcceptable && previousMonthPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the balance and the 1 Month Ago Paid, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!balanceAcceptable && twoMonthsPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the balance and the 2 Months Ago Paid, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!balanceAcceptable && threeMonthsPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the balance and the 3 Months Ago Paid, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!minDueAcceptable && previousMonthPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the minimum due and the 1 Month Ago Paid, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!minDueAcceptable && twoMonthsPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the minimum due and the 2 Months Ago Paid, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!minDueAcceptable && threeMonthsPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the minimum due and the 3 Months Ago Paid, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!previousMonthPaidAcceptable && twoMonthsPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the 1 Month Ago Paid and the 2 Months Ago Paid, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!previousMonthPaidAcceptable && twoMonthsPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the 1 Month Ago Paid and the 3 Months Ago Paid, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!twoMonthsPaidAcceptable && threeMonthsPaidAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the 2 Months Ago Paid and the 3 Months Ago Paid, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AssignBill()
        {
            GlobalBillLists.billList[GlobalBillLists.billListIndex].Name =
                txtName.Text;
            GlobalBillLists.billList[GlobalBillLists.billListIndex].DueDate =
                txtDueDate.Text;
            GlobalBillLists.billList[GlobalBillLists.billListIndex].Balance =
                Convert.ToDecimal(txtBalance.Text);
            GlobalBillLists.billList[GlobalBillLists.billListIndex].MinDue =
                Convert.ToDecimal(txtMinDue.Text);
            GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[0].Date =
                txt1MonthAgoDate.Text;
            GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[0].paidAmount =
                Convert.ToDecimal(txt1MonthAgoPaid.Text);
            GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[1].Date =
                txt2MonthsAgoDate.Text;
            GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[1].paidAmount =
                Convert.ToDecimal(txt2MonthsAgoPaid.Text);
            GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[2].Date =
                txt3MonthsAgoDate.Text;
            GlobalBillLists.billList[GlobalBillLists.billListIndex].previousPayments[2].paidAmount =
                Convert.ToDecimal(txt3MonthsAgoPaid.Text);
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            grpPreviousMonth.Enabled = true;
        }
    }    
}
