using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Snacks : Product
    {
        public Snacks(int iD, string productName, int pris, string typeOfProduct) : base(iD, productName, pris, typeOfProduct)
        {
        }
        public override void Use()
        {
            Console.WriteLine("Have some snacks to keep your energy up :D!");
        }
    }
}
