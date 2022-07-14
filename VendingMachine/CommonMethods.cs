using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public static class CommonMethods
    {
        public static void PrintBalance(int saldo)
        {
            Console.WriteLine($"Your current balance is : " + saldo.ToString());
        }

        public static bool YesOrNo(String text)
        {
            Console.Write(text + " (y/n) ?");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine();
                return false;
            }
        }

        public static void PressAnyKey()
        {
            Console.Write("Press any key to continue!"); Console.ReadKey();
        }

        public static void ExamineProduct()
        {
             //Console.WriteLine("Examine Prodct");
            // Console.ReadLine();

        }


        public static void UseProduct(Product product)
        {
            if (product.typeOfProduct == "Drink")
            {
                Console.WriteLine("The drink you bought is ready to drink, well cooled!");
            }
            if (product.typeOfProduct == "Food")
            {
                Console.WriteLine("Eat the food slowly and enjoy the good taste!");
            }
            if (product.typeOfProduct == "Candy")
            {
                Console.WriteLine("Candy is not what the dentist recommends!");
            }
            if (product.typeOfProduct == "Snacks")
            {
                Console.WriteLine("Have some snacks to keep your energy up :D!");
            }
        }
    }
}
