using System;

namespace DelieverableTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome! How many people in your party? We can only accommodate party sizes of 6 and under at this time. The cost per guest is $9.99 today.");

            int partySize = int.Parse(Console.ReadLine());

            if (partySize > 6)
            {
                Console.WriteLine("Sorry, we cannot accomodate parties over 6.");
                return;

            }

            Console.WriteLine("ok, table for " + partySize + ", follow me over here.");
            Console.WriteLine(" ");
            Console.WriteLine("What would you all like to drink? We have coffee and water. Coffee is $3.00, and water is on the house.");

            string drink;
            int waters = 0;
            int coffees = 0;

            for (int i = 1; i <= partySize; i++)
            {
                Console.WriteLine("Ok, guest #" + i + ", coffee or water?");
                drink = Console.ReadLine();

                if (drink == "water")
                {
                    waters = waters + 1;
                    Console.WriteLine("water, sounds good.");
                }

                else if (drink == "coffee")
                {
                    coffees = coffees + 1;
                    Console.WriteLine("coffee, sounds good.");
                }

                else
                {
                    Console.WriteLine("We only have water or coffee. No drink for you today, I suppose");
                }

            }

            Console.WriteLine("Ok, so that's " + waters + " waters and " + coffees + " coffees. I will be right back, you may go get your food at any time.");
            Console.WriteLine(" ");

            double coffeeCost = coffees * 3.00;
            double buffetCost = partySize * 9.99;
            double totalCost = buffetCost + coffeeCost;

            Console.WriteLine("Here is your bill:");
            
            Console.WriteLine("You ordered " + waters + " waters, these are free.");
            Console.WriteLine("You ordered " + coffees + " coffees, this costs $" + coffeeCost + " total.");
            Console.WriteLine("The buffet costs $" + buffetCost + " for " + partySize + " people.");

            Console.WriteLine("The total cost is $" + totalCost + ", please do not forget about the tip :) ");


        }
    }
}
