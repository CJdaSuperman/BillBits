using System;

namespace BillOrganizer
{
    public class Bill
    {
        public int Id { get; set; }  //used to Id it in databases  
        public string Name { get; set; }
        public string DueDate { get; set; }
        public decimal Balance { get; set; }
        public decimal MinDue { get; set; }
        public string DatePaid { get; set; }
        public decimal PaidAmount { get; set; }
        public bool isPaid { get; set; }  
        public string Note { get; set; }
        
        public struct PreviousPayment
        {
            public string Date { get; set; }
            public decimal paidAmount { get; set; }
        }

        public PreviousPayment[] previousPayments = new PreviousPayment[3];

        public int years, months;

        public Bill() {}

        public Bill(string name, string dueDate, decimal balance, decimal minDue)
        {
            Name = name;
            DueDate = dueDate;
            Balance = balance;
            MinDue = minDue;
            isPaid = false;
        }

        public void CalculateTimeToPayOff()
        {
            if(PaidAmount == 0)            
                months = Decimal.ToInt32(Balance / MinDue) + 1;            
            else            
                months = Decimal.ToInt32(Balance / PaidAmount) + 1;
            
            years = months / 12;
            months -= years * 12;
        }   
        
        public void ChangeDueDateMonth()
        {           
            string monthString = DueDate.Substring(0, DueDate.IndexOf("/"));

            string day = DueDate.Substring(DueDate.IndexOf("/"), DueDate.Length - monthString.Length);

            int monthNum = int.Parse(monthString);
            
            monthString = (++monthNum).ToString();

            DueDate = monthString + day;
        }
    }
}
