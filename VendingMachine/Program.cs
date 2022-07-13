using System;
using VendingMachine;



VM vm = new VM();   




void PrintMenu()
{
    System.Console.Clear();
    Console.WriteLine("-------------------   Vending Machine   ------------------");
    Console.WriteLine();
    Console.WriteLine();
    CommonMethods.PrintBalance(vm.Saldo);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Press 1 - Add Money");
    Console.WriteLine("      2 - Purchase Items");
    Console.WriteLine("      3 - Withdraw balance");
    Console.WriteLine("      4 - Show Products pris and Name");
    Console.WriteLine();
}

void PrintPurchaseHeader()
{
    System.Console.Clear();
    Console.WriteLine("-------------------   Vending Machine   ------------------");
    Console.WriteLine();
    Console.WriteLine();
    CommonMethods.PrintBalance(vm.Saldo);
    Console.WriteLine();
}

var keepAlive = true;




while (keepAlive)
{
    try
    {
        PrintMenu();

        Console.Write("Enter your choice or press <0> to exit!");
        var Choice = int.Parse(Console.ReadLine() ?? "");
        // Console.ForegroundColor = ConsoleColor.Green;
        switch (Choice)
        {
            case 1:
                vm.InsertMoney();
                break;
            case 2:
                PrintPurchaseHeader();
                vm.Purchase();
                break;
            case 3:
                vm.EndTransaction();
                break;
            case 4:
                PrintPurchaseHeader();
                vm.ShowAll();
                
                break;

            case 0:
                keepAlive = false;
                break;
            default:
                // Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not a valid assignment number!");
                break;

        }
        if (Choice > 0)
        {
            Console.ResetColor();
            Console.WriteLine();
            // Console.WriteLine("Hit any key to continue!");
            // Console.ReadKey();
            // Console.Clear();
        }
        else
        {
            keepAlive = false;
            break;
        }
    }

    catch
    { // Console.ForegroundColor = ConsoleColor.Green; } 

    }
}
