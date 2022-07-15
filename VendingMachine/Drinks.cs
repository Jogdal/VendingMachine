using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Drinks : Product
    {
        public Drinks(int iD, string productName, int pris, string typeOfProduct) : base(iD, productName, pris, typeOfProduct)
        {
        }

        public override void Use()
        {
            Console.WriteLine("The drink you bought is ready to drink, well cooled!");
        }
    }
}
