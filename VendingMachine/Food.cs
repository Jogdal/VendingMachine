using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Food : Product
    {
        public Food(int iD, string productName, int pris, string typeOfProduct) : base(iD, productName, pris, typeOfProduct)
        {
        }
        public override void Use()
        {
            Console.WriteLine("Eat the food slowly and enjoy the good taste!");
        }
    }
}
