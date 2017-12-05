using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Toppings
    {
        public Cupcake ck;

        public static void ToppingsOpening()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Last step! You just need to pick your toppings");
            toppings();
        }

        public static void toppings()
        {
            string OnTop;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You have the options of:");
            Console.WriteLine("1. Chocolate Sauce-$0.39");
            Console.WriteLine("2. Caramel Drizzle-$0.49");
            Console.WriteLine("3. Sprinkles-$0.25");
            Console.WriteLine("4. Chocolate Chips-$0.35");
            Console.WriteLine("5. Coconut-$0.25");
            Console.WriteLine("6. Nothing/No more");

            OnTop = Console.ReadLine();

            //updates the toppings value and lets the player chose multiple by looping the switch
            switch(OnTop)
            {
                case "1":
                    {
                        Cupcake.ChocolateSauce++;
                        Cupcake.Total += 0.39;
                        toppings();
                        break;
                    }
                case "2":
                    {
                        Cupcake.CaramelDrizzle++;
                        Cupcake.Total += 0.49;
                        toppings();
                        break;
                    }
                case "3":
                    {
                        Cupcake.Sprinkles++;
                        Cupcake.Total += 0.25;
                        toppings();
                        break;
                    }
                case "4":
                    {
                        Cupcake.ChocolateChips++;
                        Cupcake.Total += 0.35;
                        toppings();
                        break;
                    }
                case "5":
                    {
                        Cupcake.Coconut++;
                        Cupcake.Total += 0.25;
                        toppings();
                        break;
                    }
                case "6":
                    {
                        CheckOut.checkOut();
                        break;
                    }
            }
        }
    }
}
