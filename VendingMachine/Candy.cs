using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Candy : Product
    {
        public Candy(int iD, string productName, int pris, string typeOfProduct) : base(iD, productName, pris, typeOfProduct)
        {
        }
        public override void Use()
        {
            Console.WriteLine("Candy is not what the dentist recommends!");
        }
    }
}
