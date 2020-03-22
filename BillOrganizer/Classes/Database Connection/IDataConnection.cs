using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillOrganizer.Classes
{   
    public interface IDataConnection
    {
        void LoadBills();
        void CreateBill(Bill bill);
        void UpdateEdit();
    }
}
