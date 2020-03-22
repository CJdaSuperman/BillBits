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
    public partial class PaidEditForm : Form
    {
        PaidOffForm paidOffForm;

        public PaidEditForm()
        {
            InitializeComponent();
            DisplayBill();
        }

        public PaidEditForm(PaidOffForm parent)
        {
            InitializeComponent();
            DisplayBill();
            paidOffForm = parent;
        }

        private void DisplayBill()
        {
            txtName.Text = GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).Name;
            txtDueDate.Text = GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).DueDate;
            txtBalance.Text = Convert.ToString(GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).Balance);
            txtMinDue.Text = Convert.ToString(GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).MinDue);
            txtDatePaid.Text = GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).DatePaid;
            txtPaidAmount.Text = Convert.ToString(GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).PaidAmount);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                AssignBill();

                GlobalConfig.Connection.UpdateEdit();

                GlobalBillLists.OrganizeBillList();

                paidOffForm.WireList();

                this.Close();
            }
        }

        bool ValidateForm()
        {
            if (txtName.Text.Length == 0 ||
                txtDueDate.Text.Length == 0 ||
                txtBalance.Text.Length == 0 ||
                txtMinDue.Text.Length == 0 ||
                txtDatePaid.Text.Length == 0 ||
                txtPaidAmount.Text.Length == 0)
            {
                MessageBox.Show("All fields need to be entered.", "Invalid Entry",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal balanceResult, minDueResult, paidAmountResult;
            bool balanceAcceptable = Decimal.TryParse(txtBalance.Text, out balanceResult);
            bool minDueAcceptable = Decimal.TryParse(txtMinDue.Text, out minDueResult);
            bool paidAmountAcceptable = Decimal.TryParse(txtPaidAmount.Text, out paidAmountResult);

            if (!balanceAcceptable)
            {
                MessageBox.Show("Enter in a correct number for the balance, without dollar sign.",
                    "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!minDueAcceptable)
            {
                MessageBox.Show("Enter in a correct number for the minimum due, without dollar sign.",
                    "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if(!paidAmountAcceptable)
            {
                MessageBox.Show("Enter in a correct number for the paid amount, without dollar sign.",
                    "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!balanceAcceptable && !minDueAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the balance and the minimum due, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!balanceAcceptable && !paidAmountAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the balance and the paid amount, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!minDueAcceptable && !paidAmountAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the minimum due and the paid amount, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AssignBill()
        {
            GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).Name =
                                            txtName.Text;
            GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).DueDate =
                txtDueDate.Text;
            GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).Balance =
                Convert.ToDecimal(txtBalance.Text);
            GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).MinDue =
                Convert.ToDecimal(txtMinDue.Text);
            GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).DatePaid =
                txtDatePaid.Text;
            GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).PaidAmount =
                Convert.ToDecimal(txtPaidAmount.Text);
        }        
    }
}
