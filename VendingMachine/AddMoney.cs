using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VendingMachine
{
  
    public class AddMoney
    {
        public void PrintAddMoneyMenu()
        {
            
            Console.WriteLine("-------------------   Add Money --------------------------");
            Console.WriteLine();
            commonMethods.PrintBalance();
            Console.WriteLine();
        }
        
    }
}
