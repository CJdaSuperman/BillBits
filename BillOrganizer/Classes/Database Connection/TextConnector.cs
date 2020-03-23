using BillOrganizer.Classes.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace BillOrganizer.Classes
{
    public class TextConnector : IDataConnection
    {
        const string billsFile = "Bills.csv";

        //Loads the bills from the text file to be displayed in the Bills form
        public void LoadBills()
        {
            //these extension methods are in TextConnectorProcessor
            List<Bill> bills = billsFile.FullFilePath().LoadFile().ConvertToBill();

            GlobalBillLists.billList = bills;
            GlobalBillLists.OrganizeBillList();
        }

        public void CreateBill(Bill bill)
        {
            List<Bill> bills = billsFile.FullFilePath().LoadFile().ConvertToBill();

            int currentId = 1;

            if(bills.Count > 0)
            {
                //so the bill created here has a unique id, currentId is the highest id on the list
                //added by 1
                currentId = bills.OrderByDescending(b => b.Id).First().Id + 1;
            }

            bill.Id = currentId;

            bills.Add(bill);

            GlobalBillLists.billList = bills;

            GlobalBillLists.billList.SaveToBillsFile(billsFile);
        }

        //used when a bill's info has been edited by any of the Edit forms and needs to be 
        //saved onto the file
        public void UpdateEdit() => GlobalBillLists.billList.SaveToBillsFile(billsFile);
    }
}
