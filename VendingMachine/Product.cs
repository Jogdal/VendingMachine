using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VendingMachine
{
    public abstract class Product
    {

        // constructor
        public Product(int iD, string productName, int pris, string typeOfProduct)
        {
            ID = iD;
            ProductName = productName;
            Pris = pris;
            TypeOfProduct = typeOfProduct;
        }
    
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Pris { get; set; }

        public string TypeOfProduct { get; set; }

        public void ShowProductsNamePris()
        {
            // Console.WriteLine(");
        }

        public void Examine()
        {
            Console.WriteLine(ProductName + " kostar " + Pris + "kr  Varugrupp: " + TypeOfProduct);
           

        }

        public virtual void Use()
        {
            

        }

    }
}
