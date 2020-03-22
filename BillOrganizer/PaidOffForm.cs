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

        private void btnExpand_Click(object sender, EventArgs e)
        {
            GlobalBillLists.selectedBill = (Bill)lstPaidBills.SelectedItem;

            if (GlobalBillLists.selectedBill != null)
            {
                ExpandForm expandForm = new ExpandForm();
                expandForm.Show();
            }                
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Bill bill = (Bill)lstPaidBills.SelectedItem;

            if(bill != null)
            {
                GlobalBillLists.FindBillListIndex(bill);

                PaidEditForm editForm = new PaidEditForm(this);
                editForm.Show();
            }                        
        }

        private void btnRestore_Click(object sender, EventArgs e)
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

        private void btnDeleteBill_Click(object sender, EventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bills billsForm = new Bills();
            billsForm.Closed += (s, args) => this.Close();
            billsForm.Show();
        }

        private void lblNextMonth_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will start a new month to pay bills. " +
                "Do you wish to continue?", "Go To Next Month", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (Bill b in GlobalBillLists.billList)
                {
                    b.previousPayments[2].Date = b.previousPayments[1].Date;
                    b.previousPayments[2].paidAmount = b.previousPayments[1].paidAmount;
                    b.previousPayments[1].Date = b.previousPayments[0].Date;
                    b.previousPayments[1].paidAmount = b.previousPayments[0].paidAmount;
                    b.previousPayments[0].Date = b.DatePaid;
                    b.previousPayments[0].paidAmount = b.PaidAmount;
                    b.isPaid = false;
                    b.DatePaid = "";
                    b.PaidAmount = 0m;
                }

                GlobalConfig.Connection.UpdateEdit();

                GlobalBillLists.OrganizeBillList();

                WireList();
            }
            else
            {
                return;
            }            
        }
    }
}
