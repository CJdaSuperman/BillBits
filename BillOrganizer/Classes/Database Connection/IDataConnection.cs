namespace BillOrganizer.Classes
{   
    public interface IDataConnection
    {
        void LoadBills();
        void CreateBill(Bill bill);
        void UpdateEdit();
    }
}
