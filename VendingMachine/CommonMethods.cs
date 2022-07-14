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

        public static void ExamineProduct(Product product)
        {
            // Console.WriteLine("Examine Prodct " + product.ID + "  " + product.ProductName + " " + product.Pris +"kr  Varugrupp: " + product.typeOfProduct );

            if (product.ID < 10)
            {
                Console.Write(product.ID + "   " + product.ProductName);
            }
            else
            {
                Console.Write(product.ID + "  " + product.ProductName);
            }

            int nrOfSpaces = 30 - product.ProductName.Length;
            for (int i = 0; i < nrOfSpaces; i++)
            {
                Console.Write(" ");
            }
            if (product.Pris < 10) Console.Write(" ");

            Console.Write(product.Pris + "kr");
            Console.WriteLine("  Varugrupp: " + product.typeOfProduct);
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




        public static bool CheckMinBalance(int Saldo)
        {
            if (Saldo >= 3) return true;
            else
                return false;
        }

        public static bool CheckCashToDispence(int Saldo)
        {
            if (Saldo >= 1) return true;
            else
                return false;
        }
        public static bool CheckIfTheUserIsACheepMotherF(int NoOfPurchases)

        {
            if (NoOfPurchases > 0) return true;
            else
                return false;
        }


        public static bool CheckDeposit(int depositAmount)
        {
            switch (depositAmount)
            {
                case 1:
                    return true;
                    break;
                case 2:
                    return true;
                    break;
                case 5:
                    return true;
                    break;
                case 10:
                    return true;
                    break;
                case 20:
                    return true; ;
                    break;
                case 50:
                    return true; 
                    break;
                case 100:
                    return true;
                    break;
                case 500:
                    return true;
                    break;
                case 1000:
                    return true;
                    break;
                case 0:
                    return false;
                    break;
                default:
                    return false;
                break;
            }
        }   
    }
}
