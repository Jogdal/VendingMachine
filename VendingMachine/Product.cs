using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VendingMachine
{
    public abstract class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Pris { get; set; }

        public void ShowProductsNamePris()
        {
            //Console.WriteLine("Produkten " +  " kostar " + + " kronor");
        }
    }
}
