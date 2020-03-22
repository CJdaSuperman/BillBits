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
    public partial class PayForm : Form
    {
        Bills billsForm;

        public PayForm()
        {
            InitializeComponent();
        }

        public PayForm(Bills parent)
        {
            InitializeComponent();
            billsForm = parent;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                ApplyPayInformation();

                GlobalConfig.Connection.UpdateEdit();

                GlobalBillLists.OrganizeBillList();

                billsForm.WireList();

                this.Close();
            }
        }        

        bool ValidateForm()
        {
            if (txtDatePaid.Text.Length == 0 ||
                txtAmountPaid.Text.Length == 0)
            {
                MessageBox.Show("All fields need to be entered.", "Invalid Entry",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal paidAmountResult;
            bool paidAmountAcceptable = Decimal.TryParse(txtAmountPaid.Text, out paidAmountResult);


            if(!paidAmountAcceptable)
            {
                MessageBox.Show("Enter in a correct number for Amount Paid, without dollar sign.", 
                    "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        void ApplyPayInformation()
        {
            GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).isPaid = true;
            GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).DatePaid =
                txtDatePaid.Text;
            GlobalBillLists.billList.ElementAt(GlobalBillLists.billListIndex).PaidAmount =
                Convert.ToDecimal(txtAmountPaid.Text);
        }
    }
}
