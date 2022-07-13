using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine
{
    internal class VM : IVending
    {
        public int balance { get; set; }

        // Constructor som körs när vi skapar objektet i Program.cs
        public VM()
        {
            myProductList = new List<Product>();

            InitInventory();
           
        }

        public List<Product> myProductList { get; set; }
        public int Saldo { get; set; } = 0;

        internal int NumOfDeposits { get; set; } = 0;

       

        public void InsertMoney()
        {
            Console.WriteLine("Add Money in the following values: 1kr 5kr 10kr 20kr 50kr 100kr 500kr and 1000kr");

            Console.WriteLine();
            Console.WriteLine("Press <0> to end deposit!");
            Console.WriteLine();
            
            int deposit = int.Parse(Console.ReadLine());
            
            switch (deposit)
            {

                case 1:
                    Saldo += deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull");
                    break;
                case 2:
                    Saldo += deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull");
                    
                    break;
                case 5:
                    Saldo += deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull");
                    
                    break;
                case 10:
                    Saldo += deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull");
                    
                    break;
                case 20:
                    Saldo += deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull");
                    
                    break;
                case 50:
                    Saldo += deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull");
                    
                    break;
                case 100:
                    Saldo += deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull");
                    
                    break;
                case 500:
                    Saldo += deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull");
                    
                    break;
                case 1000:
                    Saldo += deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull");
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("That is not a valid deposit!");
                  break;
            }
            // Console.WriteLine("New balance: " + Saldo);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
            Console.Clear();

            
        }

        public void Purchase()
        {

            // Visa vilka artiklar som finns att köpa
            Console.WriteLine("List of products to Purchase ");
            foreach (Product product in myProductList)
            {
                if (product.ID < 10)
                {
                    Console.Write(product.ID + "   " + product.ProductName);
                }
                else
                {
                    Console.Write(product.ID + "  " + product.ProductName);
                }

                int nrOfSpaces = 20 - product.ProductName.Length;
                for (int i = 0; i < nrOfSpaces; i++) 
                { 
                    Console.Write(" "); 
                }
                Console.WriteLine(product.Pris + "kr");
            }

            Console.Write("Please make a purchase by entering the productnumber:  ");
            int itemToPurchase = Convert.ToInt32(Console.ReadLine());
            
            foreach (Product product in myProductList)
            {
                if (itemToPurchase == product.ID)
                {
                    Console.WriteLine();
                bool purchase = CommonMethods.YesOrNo("Are you sure you want to purchase " + product.ProductName + " for ");

                    if (purchase)
                    {
                        if(Saldo >= product.Pris)
                        {
                            Saldo -= product.Pris;
                            Console.WriteLine();
                            Console.WriteLine("The drink you bought is ready to drink, well cooled!");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Sorry mate, your out of cash, Get a job and put in some more money!");
                        }
                    }
               

                }
            }
            Console.ReadLine();
        }


        public void EndTransaction()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dispensing the Cash!");

            Console.WriteLine("You have " + Saldo);

            if(Saldo >= 1000)
            {
                int nrOfThousands = Saldo / 1000;
                Console.WriteLine($"You will get {nrOfThousands} of thousand notes!");
                Saldo -= ( nrOfThousands *1000);
            }
            if(Saldo >= 500)
            {
                int nrOfFivers = Saldo / 500;
                Console.WriteLine($"You will get {nrOfFivers} of fivehundred notes!");
                Saldo -= (nrOfFivers * 500);
            }
            if (Saldo >= 100)
            {
                int nrOfHundreds = Saldo / 100;
                Console.WriteLine($"You will get {nrOfHundreds} of hundreddollar notes!");
                Saldo -= (nrOfHundreds * 100);
            }
            if (Saldo >= 50)
            {
                int nrOfFiftys = Saldo / 50;
                Console.WriteLine($"You will get {nrOfFiftys} of fifty notes!");
                Saldo -= (nrOfFiftys * 50);
            }
            if (Saldo >= 20)
            {
                int nrOfTwenties = Saldo / 20;
                Console.WriteLine($"You will get {nrOfTwenties} of twenty dollar notes!");
                Saldo -= (nrOfTwenties * 20);
            }
            if (Saldo >= 10)
            {
                int nrOfTens = Saldo / 10;
                Console.WriteLine($"You will get {nrOfTens} of ten dollar notes!");
                Saldo -= (nrOfTens * 10);
            }
            if (Saldo >= 20)
            {
                int nrOfFives = Saldo / 5;
                Console.WriteLine($"You will get {nrOfFives} of five dollar notes!");
                Saldo -= (nrOfFives * 5);
            }
            if (Saldo >= 1)
            {
                int nrOfTwenties = Saldo / 1;
                Console.WriteLine("You will not get the remaining balance. In Switzerland they called it Adjo fee!");
                Saldo -= (nrOfTwenties * 1);
            }



            Console.ReadLine();
        }

        public void ShowAll()
        {
            Console.WriteLine("List of products to Purchase ");
            foreach (Product product in myProductList)
            {
                if (product.ID < 10)
                {
                    Console.Write(product.ID + "   " + product.ProductName);
                }
                else
                {
                    Console.Write(product.ID + "  " + product.ProductName);
                }

                int nrOfSpaces = 20 - product.ProductName.Length;
                for (int i = 0; i < nrOfSpaces; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(product.Pris + "kr");
            }
            Console.WriteLine();
            Console.Write("Press any key to Continue!"); Console.ReadLine();
        }

    public void InitInventory()
        {
            Drinks myCola = new Drinks();
            myCola.ID = 1;
            myCola.ProductName = "Cola";
            myCola.Pris = 10;

            Drinks myFanta = new Drinks();
            myFanta.ID = 2;
            myFanta.ProductName = "Fanta";
            myFanta.Pris = 10;

            Drinks myLoka = new Drinks();
            myLoka.ID = 3;  
            myLoka.ProductName = "Loka";
            myLoka.Pris = 10;


            Food mySnickers = new Food();
            mySnickers.ID = 4;
            mySnickers.ProductName = "Snickers";
            mySnickers.Pris = 15;

            Food myTwix = new Food();
            myTwix.ID = 5;
            myTwix.ProductName = "Twix";
            myTwix.Pris = 15;

            Food myJapp = new Food();
            myJapp.ID = 6;
            myJapp.ProductName = "Japp";
            myJapp.Pris = 15;

            Snacks myLakrits = new Snacks();
            myLakrits.ID = 7;
            myLakrits.ProductName = "Lakris";
            myLakrits.Pris = 10;

            Snacks myAhlgrens = new Snacks();
            myAhlgrens.ID = 8;
            myAhlgrens.ProductName = "Ahlgrens Bilar";
            myAhlgrens.Pris = 25;

            Snacks myDjungelvral = new Snacks();
            myDjungelvral.ID = 9;   
            myDjungelvral.ProductName = "Djungelvrål";
            myDjungelvral.Pris = 10;

            Candy mySalmiakbalk = new Candy();
            mySalmiakbalk.ID = 10;
            mySalmiakbalk.ProductName = "Salmiak balk";
            mySalmiakbalk.Pris = 3;


            

            myProductList.Add(myCola);
            myProductList.Add(myFanta);
            myProductList.Add(myLoka);
            myProductList.Add(mySnickers);
            myProductList.Add(myTwix);
            myProductList.Add(myJapp);
            myProductList.Add(myLakrits);
            myProductList.Add(myAhlgrens);
            myProductList.Add(myDjungelvral);
            myProductList.Add(mySalmiakbalk);



            


        }



    }
}
