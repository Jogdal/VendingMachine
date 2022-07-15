using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal interface IVending
    {
        public void InsertMoney();
        public void ShowAll();
        public void Purchase();
        public void EndTransaction();
    }
}
