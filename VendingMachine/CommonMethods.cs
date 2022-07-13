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

    }
}
