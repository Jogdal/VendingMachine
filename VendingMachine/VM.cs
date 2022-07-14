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
        public int nrOfPurchases { get; set; } = 0;
        public int[] aDeposit = new int[9999];
        public string[] aPurchasedItems = new string[9999];

        internal int NumOfDeposits { get; set; } = 0;

       

        public void InsertMoney()
        {
            Console.Clear();
            Console.WriteLine("--------------------   Adding Money to the Machine  --------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Add Money in the following values: 1kr 5kr 10kr 20kr 50kr 100kr 500kr and 1000kr");

            Console.WriteLine();
            Console.WriteLine("Press <0> to end deposit!");
            Console.WriteLine();


            int deposit = int.Parse(Console.ReadLine());

            // if (CommonMethods.CheckDeposit(deposit)) { Console.WriteLine("Deposit value OK "); CommonMethods.PressAnyKey(); }

            switch (deposit)
            {
                case 1:
                    Saldo += deposit;
                    aDeposit[NumOfDeposits] = deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull. New balance: {Saldo}");
                    break;
                case 2:
                    Saldo += deposit;
                    aDeposit[NumOfDeposits] = deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull. New balance: {Saldo}");
                    
                    break;
                case 5:
                    Saldo += deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull. New balance: {Saldo}");
                    
                    break;
                case 10:
                    Saldo += deposit;
                    aDeposit[NumOfDeposits] = deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull. New balance: {Saldo}");
                    
                    break;
                case 20:
                    Saldo += deposit;
                    aDeposit[NumOfDeposits] = deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull. New balance: {Saldo}");
                    
                    break;
                case 50:
                    Saldo += deposit;
                    aDeposit[NumOfDeposits] = deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull. New balance: {Saldo}");
                    
                    break;
                case 100:
                    Saldo += deposit;
                    aDeposit[NumOfDeposits] = deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull. New balance: {Saldo}");
                    
                    break;
                case 500:
                    Saldo += deposit;
                    aDeposit[NumOfDeposits] = deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull. New balance: {Saldo}");
                    
                    break;
                case 1000:
                    Saldo += deposit;
                    aDeposit[NumOfDeposits] = deposit;
                    NumOfDeposits++;
                    Console.WriteLine($"Your deposit of {deposit}kr was successfull. New balance: {Saldo}");
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("That is not a valid amount to deposit!");
                  break;
            }
            // Console.WriteLine("New balance: " + Saldo);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Successfull deposits:");
            Console.WriteLine();

            for (int i = 0; i < NumOfDeposits; i++)
            {
                Console.WriteLine(aDeposit[i]);
            }
            Console.WriteLine();
            CommonMethods.PressAnyKey();
            Console.Clear();

            
        }

        public void Purchase()
        {

            if (CommonMethods.CheckMinBalance(Saldo))
            {
                // Visa vilka artiklar som finns att köpa
                Console.WriteLine("List of products to Purchase ");
                Console.WriteLine();
                foreach (Product product in myProductList)
                {
                    CommonMethods.ExamineProduct(product);
                }

                Console.WriteLine();
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
                            if (Saldo >= product.Pris)
                            {
                                Saldo -= product.Pris;
                                Console.WriteLine();

                                CommonMethods.UseProduct(product);

                                aPurchasedItems[nrOfPurchases] = product.ProductName;
                                nrOfPurchases++;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Sorry mate, your out of cash, Get a job and put in some more money!");
                            }
                        }


                    }
                }

                Console.WriteLine();

                if (nrOfPurchases > 0)
                {
                    Console.WriteLine("You have successfully purchased the following items:");
                    Console.WriteLine();
                    for (int p = 0; p < nrOfPurchases; p++)
                    {
                        Console.WriteLine("     " + aPurchasedItems[p]);
                    }
                }
                Console.WriteLine();
                CommonMethods.PressAnyKey();
            }
            else
            {
                Console.WriteLine("Sorry mate, you need to deposit some more cash before you can purchase anything, Get yourself an haircut and get job!!!");
                Console.WriteLine();
                CommonMethods.PressAnyKey();    
            }
        }


        public void EndTransaction()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dispensing the Cash!");
            Console.WriteLine();

            Console.WriteLine("You have " + Saldo);

            if(Saldo >= 1000)
            {
                int nrOfThousands = Saldo / 1000;
                Console.WriteLine($"You will get {nrOfThousands} thousand notes!");
                Saldo -= ( nrOfThousands *1000);
            }
            if(Saldo >= 500)
            {
                int nrOfFivers = Saldo / 500;
                Console.WriteLine($"You will get {nrOfFivers} fivehundred notes!");
                Saldo -= (nrOfFivers * 500);
            }
            if (Saldo >= 100)
            {
                int nrOfHundreds = Saldo / 100;
                Console.WriteLine($"You will get {nrOfHundreds} hundreddollar notes!");
                Saldo -= (nrOfHundreds * 100);
            }
            if (Saldo >= 50)
            {
                int nrOfFiftys = Saldo / 50;
                Console.WriteLine($"You will get {nrOfFiftys} fifty notes!");
                Saldo -= (nrOfFiftys * 50);
            }
            if (Saldo >= 20)
            {
                int nrOfTwenties = Saldo / 20;
                Console.WriteLine($"You will get {nrOfTwenties} twenty dollar notes!");
                Saldo -= (nrOfTwenties * 20);
            }
            if (Saldo >= 10)
            {
                int nrOfTens = Saldo / 10;
                Console.WriteLine($"You will get {nrOfTens} ten dollar notes!");
                Saldo -= (nrOfTens * 10);
            }
            if (Saldo >= 20)
            {
                int nrOfFives = Saldo / 5;
                Console.WriteLine($"You will get {nrOfFives} five dollar notes!");
                Saldo -= (nrOfFives * 5);
            }
            if (Saldo >= 1)
            {
                int nrOfCoins = Saldo / 1;
                Console.WriteLine();
                Console.WriteLine("The Machine keeps the remaining balance of " + Saldo + ". The Swiss bankers call it Adjo fee!");
                Saldo -= (nrOfCoins * 1);
            }



            Console.ReadLine();
        }

        public void ShowAll()
        {
            Console.WriteLine("List of products to Purchase ");
            Console.WriteLine();
            foreach (Product product in myProductList)
            {
                CommonMethods.ExamineProduct(product);
            }

            Console.WriteLine();
            
            CommonMethods.PressAnyKey();
        }

    public void InitInventory()
        {
            Drinks myCola = new Drinks();
            myCola.ID = 1;
            myCola.ProductName = "Cola";
            myCola.Pris = 10;
            myCola.typeOfProduct = "Drink";

            Drinks myFanta = new Drinks();
            myFanta.ID = 2;
            myFanta.ProductName = "Fanta";
            myFanta.Pris = 10;
            myFanta.typeOfProduct = "Drink";

            Drinks myLoka = new Drinks();
            myLoka.ID = 3;  
            myLoka.ProductName = "Loka";
            myLoka.Pris = 10;
            myLoka.typeOfProduct = "Drink";


            Food mySnickers = new Food();
            mySnickers.ID = 4;
            mySnickers.ProductName = "Snickers";
            mySnickers.Pris = 15;
            mySnickers.typeOfProduct = "Food";

            Food myTwix = new Food();
            myTwix.ID = 5;
            myTwix.ProductName = "Twix";
            myTwix.Pris = 15;
            myTwix.typeOfProduct = "Food";

            Food myJapp = new Food();
            myJapp.ID = 6;
            myJapp.ProductName = "Japp";
            myJapp.Pris = 15;
            myJapp.typeOfProduct = "Food";

            Food mySalamieBrie = new Food();
            mySalamieBrie.ID = 7;
            mySalamieBrie.ProductName = "Salamie Brie Sandwich";
            mySalamieBrie.Pris = 15;
            mySalamieBrie.typeOfProduct = "Food";


            Candy myLakrits = new Candy();
            myLakrits.ID = 8;
            myLakrits.ProductName = "Lakris";
            myLakrits.Pris = 10;
            myLakrits.typeOfProduct = "Candy";

            Candy myAhlgrens = new Candy();
            myAhlgrens.ID = 9;
            myAhlgrens.ProductName = "Ahlgrens Bilar";
            myAhlgrens.Pris = 25;
            myAhlgrens.typeOfProduct = "Candy";

            Candy myDjungelvral = new Candy();
            myDjungelvral.ID = 10;   
            myDjungelvral.ProductName = "Djungelvrål";
            myDjungelvral.Pris = 10;
            myDjungelvral.typeOfProduct = "Candy";

            Candy mySalmiakbalk = new Candy();
            mySalmiakbalk.ID = 11;
            mySalmiakbalk.ProductName = "Salmiak balk";
            mySalmiakbalk.Pris = 3;
            mySalmiakbalk.typeOfProduct = "Candy";




            myProductList.Add(myCola);
            myProductList.Add(myFanta);
            myProductList.Add(myLoka);
            myProductList.Add(mySnickers);
            myProductList.Add(myTwix);
            myProductList.Add(myJapp);
            myProductList.Add(mySalamieBrie);
            myProductList.Add(myLakrits);
            myProductList.Add(myAhlgrens);
            myProductList.Add(myDjungelvral);
            myProductList.Add(mySalmiakbalk);



            


        }



    }
}
