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
    public partial class ExpandForm : Form
    {
        public ExpandForm()
        {
            InitializeComponent();
            DisplayBill();
        }

        void DisplayBill()
        {
            AssignTextBoxes();

            GlobalBillLists.selectedBill.CalculateTimeToPayOff();

            txtPaidOffDate.Text = "It will take you " + GlobalBillLists.selectedBill.years +
                " years and " + GlobalBillLists.selectedBill.months + " months to pay off";
        }

        private void AssignTextBoxes()
        {
            txtName.Text = GlobalBillLists.selectedBill.Name;
            txtDueDate.Text = GlobalBillLists.selectedBill.DueDate;
            txtBalance.Text = Convert.ToString(GlobalBillLists.selectedBill.Balance);
            txtMinDue.Text = Convert.ToString(GlobalBillLists.selectedBill.MinDue);
            txtDatePaid.Text = GlobalBillLists.selectedBill.DatePaid;
            txtPaidAmount.Text = Convert.ToString(GlobalBillLists.selectedBill.PaidAmount);
            txtNotes.Text = GlobalBillLists.selectedBill.Note;

            for (int i = 0; i < GlobalBillLists.selectedBill.previousPayments.Length; i++)
            {
                if (GlobalBillLists.selectedBill.previousPayments[i].Date != null)
                {
                    switch (i)
                    {
                        case 0:
                            txt1MonthAgoDate.Text = GlobalBillLists.selectedBill.previousPayments[i].Date;
                            txt1MonthAgoPaid.Text = Convert.ToString(GlobalBillLists.selectedBill.previousPayments[i].paidAmount);
                            break;
                        case 1:
                            txt2MonthsAgoDate.Text = GlobalBillLists.selectedBill.previousPayments[i].Date;
                            txt2MonthsAgoPaid.Text = Convert.ToString(GlobalBillLists.selectedBill.previousPayments[i].paidAmount);
                            break;
                        case 2:
                            txt3MonthsAgoDate.Text = GlobalBillLists.selectedBill.previousPayments[i].Date;
                            txt3MonthsAgoPaid.Text = Convert.ToString(GlobalBillLists.selectedBill.previousPayments[i].paidAmount);
                            break;
                    }
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                decimal theoreticalAmount = Convert.ToDecimal(txtTheoreticalAmount.Text);
                int months, years;

                CalculateTheoreticalAmount(theoreticalAmount, out months, out years);

                txtPaidOffDate.Text = "It will take you " + years + " years and " +
                    months + " months to pay off";
            }
        }        

        private void btnRevert_Click(object sender, EventArgs e)
        {
            txtPaidOffDate.Text = "It will take you " + GlobalBillLists.selectedBill.years +
                " years and " + GlobalBillLists.selectedBill.months + " months to pay off";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GlobalBillLists.selectedBill.Note = txtNotes.Text;

            GlobalBillLists.FindBillListIndex(GlobalBillLists.selectedBill);

            GlobalConfig.Connection.UpdateEdit();

            MessageBox.Show("Note has been saved");
        }

        bool ValidateForm()
        {
            decimal theoreticalAmountResult;
            bool theoreticalAmountAcceptable = Decimal.TryParse(txtTheoreticalAmount.Text, 
                out theoreticalAmountResult);

            if (txtTheoreticalAmount.Text.Length == 0)
            {
                MessageBox.Show("Enter a number in Theoretical Paid Amount Box.", 
                    "Invalid Entry",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(!theoreticalAmountAcceptable)
            {
                MessageBox.Show("Enter a correct number for Theoretical Paid Amount, without dollar sign.", 
                    "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        static void CalculateTheoreticalAmount(decimal theoreticalAmount, out int months, out int years)
        {
            months = Decimal.ToInt32(GlobalBillLists.selectedBill.Balance /
                                theoreticalAmount + 1);
            years = months / 12;
            months -= years * 12;
        }        
    }
}
