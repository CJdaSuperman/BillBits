using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillOrganizer
{
    public static class GlobalBillLists
    {
        public static int billListIndex;
        
        //A list of bills that are used to read and write the bills from my text file and use 
        //them across my forms
        public static List<Bill> billList = new List<Bill>();

        //a List that shows the bills that haven't been payed off, used for the CheckedBoxList
        //in Bills Form
        public static List<Bill> activeBillList = new List<Bill>();

        //a List that shows the bills that have been payed off, used for the CheckedBoxList
        //in PaidOffForm form
        public static List<Bill> paidBillList = new List<Bill>();

        //used to determine which Bill information to display when an Expand button is pressed
        public static Bill selectedBill;

        //Uses billList to determine which bills are paid and which aren't, and organize them
        //into the activeBillLIst and paidBillList to use in the Bills and PaidOffForm, respectively
        public static void OrganizeBillList()
        {
            //everytime this method gets called, reset the lists
            activeBillList.Clear();
            paidBillList.Clear();

            foreach (Bill b in billList)
            {
                if (!b.isPaid)
                    activeBillList.Add(b);
                else
                    paidBillList.Add(b);
            }
        }

        //Assigns the billListIndex for the billList using a Bill object from one of the forms
        public static void FindBillListIndex(Bill bill)
        {
            for (int i = 0; i < billList.Count; i++)
            {
                if (bill.Name == billList.ElementAt(i).Name)
                {
                    billListIndex = i;
                    break;
                }
            }
        }
    }
}
