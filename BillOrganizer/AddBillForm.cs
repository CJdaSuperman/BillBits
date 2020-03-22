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
    public partial class AddBillForm : Form
    {
        //used to have a reference to the Bills form
        Bills billsForm;

        public AddBillForm()
        {
            InitializeComponent();
        }

        public AddBillForm(Bills parent)
        {
            InitializeComponent();
            billsForm = parent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                Bill bill = new Bill(Convert.ToString(txtName.Text), 
                    Convert.ToString(txtDueDate.Text),
                    Convert.ToDecimal(txtBalance.Text), 
                    Convert.ToDecimal(txtMinDue.Text));

                GlobalConfig.Connection.CreateBill(bill);

                GlobalBillLists.OrganizeBillList();

                billsForm.WireList();

                this.Close();
            }            
        }

        bool ValidateForm()
        {
            if(txtName.Text.Length == 0 ||                
                txtBalance.Text.Length == 0 ||
                txtMinDue.Text.Length == 0)
            {
                MessageBox.Show("All fields need to be entered.", "Invalid Entry",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal balanceResult, minDueResult;    //have to have these for following statements
            bool balanceAcceptable = Decimal.TryParse(txtBalance.Text, out balanceResult);
            bool minDueAcceptable = Decimal.TryParse(txtMinDue.Text, out minDueResult);

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

            else if (!balanceAcceptable && !minDueAcceptable)
            {
                MessageBox.Show("Enter in a correct number for both the balance and the minimum due, " +
                    "without dollar sign.", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
