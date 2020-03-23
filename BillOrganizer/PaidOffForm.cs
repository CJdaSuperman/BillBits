using BillOrganizer.Classes;
using System;
using System.Windows.Forms;

namespace BillOrganizer
{
    public partial class PaidOffForm : Form
    {
        public PaidOffForm()
        {
            InitializeComponent();
            WireList();
        }

        public void WireList()
        {
            lstPaidBills.DataSource = null;
            lstPaidBills.DataSource = GlobalBillLists.paidBillList;
            lstPaidBills.DisplayMember = "Name";
        }

        void btnExpand_Click(object sender, EventArgs e)
        {
            GlobalBillLists.selectedBill = (Bill)lstPaidBills.SelectedItem;

            if (GlobalBillLists.selectedBill != null)
            {
                ExpandForm expandForm = new ExpandForm();
                expandForm.Show();
            }                
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            Bill bill = (Bill)lstPaidBills.SelectedItem;

            if(bill != null)
            {
                GlobalBillLists.FindBillListIndex(bill);

                PaidEditForm editForm = new PaidEditForm(this);
                editForm.Show();
            }                        
        }

        void btnRestore_Click(object sender, EventArgs e)
        {
            Bill bill = (Bill)lstPaidBills.SelectedItem;

            if(bill != null)
            {
                GlobalBillLists.FindBillListIndex(bill);

                GlobalBillLists.billList[GlobalBillLists.billListIndex].isPaid = false;

                GlobalConfig.Connection.UpdateEdit();

                GlobalBillLists.OrganizeBillList();

                WireList();
            }                        
        }

        void btnDeleteBill_Click(object sender, EventArgs e)
        {
            Bill bill = (Bill)lstPaidBills.SelectedItem;

            if(bill != null)
            {
                GlobalBillLists.billList.Remove(bill);

                GlobalConfig.Connection.UpdateEdit();

                GlobalBillLists.OrganizeBillList();

                WireList();
            }            
        }

        void btnBack_Click(object sender, EventArgs e) => InstantiateBillsForm();

        void InstantiateBillsForm()
        {
            Hide();
            Bills billsForm = new Bills();
            billsForm.Closed += (s, args) => this.Close();
            billsForm.Show();
        }

        void lblNextMonth_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will start a new month to pay bills. " +
                "Do you wish to continue?", "Go To Next Month", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (Bill b in GlobalBillLists.billList)
                {
                    b.Balance -= b.PaidAmount;
                    b.ChangeDueDateMonth();
                    ReorderPreviousPayments(b);
                    b.isPaid = false;
                    b.DatePaid = "";
                    b.PaidAmount = 0m;
                }

                GlobalConfig.Connection.UpdateEdit();

                GlobalBillLists.OrganizeBillList();

                WireList();

                InstantiateBillsForm();
            }
            else
            {
                return;
            }            
        }

        void ReorderPreviousPayments(Bill b)
        {
            b.previousPayments[2].Date = b.previousPayments[1].Date;
            b.previousPayments[2].paidAmount = b.previousPayments[1].paidAmount;
            b.previousPayments[1].Date = b.previousPayments[0].Date;
            b.previousPayments[1].paidAmount = b.previousPayments[0].paidAmount;
            b.previousPayments[0].Date = b.DatePaid;
            b.previousPayments[0].paidAmount = b.PaidAmount;
        }
    }
}
