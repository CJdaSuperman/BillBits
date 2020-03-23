using BillOrganizer.Classes;
using System;
using System.Windows.Forms;

namespace BillOrganizer
{
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
            GlobalConfig.Connection.LoadBills();
            WireList();
        }

        //public access type because it's going to be called in AddBillForm
        public void WireList()
        {
            lstBills.DataSource = null;
            lstBills.DataSource = GlobalBillLists.activeBillList;            
            lstBills.DisplayMember = "Name";
        }
       

        void btnPay_Click(object sender, EventArgs e)
        {            
            Bill bill = (Bill)lstBills.SelectedItem;

            if(bill != null)
            {
                GlobalBillLists.FindBillListIndex(bill);

                PayForm payForm = new PayForm(this);
                payForm.Show();
            }                                
        }

        void btnPaid_Click(object sender, EventArgs e)
        {
            
            Hide();
            PaidOffForm paidForm = new PaidOffForm();
            paidForm.Closed += (s, args) => this.Close();
            paidForm.Show();
        }

        void btnAddBill_Click(object sender, EventArgs e)
        {            
            AddBillForm addBillFrm = new AddBillForm(this);
            addBillFrm.Show();
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            Bill bill = (Bill)lstBills.SelectedItem;

            if(bill != null)
            {
                GlobalBillLists.FindBillListIndex(bill);

                BillEditForm billEditForm = new BillEditForm(this);
                billEditForm.Show();
            }            
        }

        void btnExpand_Click(object sender, EventArgs e)
        {            
            GlobalBillLists.selectedBill = (Bill)lstBills.SelectedItem;

            if (GlobalBillLists.selectedBill != null)
            {
                ExpandForm expandForm = new ExpandForm();
                expandForm.Show();
            }                
        }

        void btnDeleteBill_Click(object sender, EventArgs e)
        {
            Bill bill = (Bill)lstBills.SelectedItem;

            if(bill != null)
            {
                GlobalBillLists.billList.Remove(bill);

                GlobalConfig.Connection.UpdateEdit();

                GlobalBillLists.OrganizeBillList();

                WireList();
            }            
        }        
    }
}
