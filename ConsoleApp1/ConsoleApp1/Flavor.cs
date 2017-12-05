using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Flavor
    {
        public static void OriginalVanilla()
        {
            string price;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Ooooo vanilla, a clasic!\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("We have 3 sizes:");
            Console.WriteLine("1. Mini-$1.99");
            Console.WriteLine("2. Standard-$3.99");
            Console.WriteLine("3. Maxi-$6.99");

            price = Console.ReadLine();

            switch (price)
            {
                case "1":
                    {
                        Cupcake.Total += 1.99;
                        Cupcake.Size = "Mini";
                        Toppings.ToppingsOpening();
                        break;
                    }
                case "2":
                    {
                        Cupcake.Total += 3.99;
                        Cupcake.Size = "Standard";
                        Toppings.ToppingsOpening();
                        break;
                    }
                case "3":
                    {
                        Cupcake.Total += 6.99;
                        Cupcake.Size = "Maxi";
                        Toppings.ToppingsOpening();
                        break;
                    }
            }
        }

        public static void Chocolate()
        {
            string price;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You can never go wrong with chocolate!\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("We have 3 sizes:");
            Console.WriteLine("1. Mini-$1.99");
            Console.WriteLine("2. Standard-$3.99");
            Console.WriteLine("3. Maci-$6.99");

            price = Console.ReadLine();

            switch (price)
            {
                case "1":
                    {
                        Cupcake.Total += 1.99;
                        Cupcake.Size = "Mini";
                        Toppings.ToppingsOpening();
                        break;
                    }
                case "2":
                    {
                        Cupcake.Total += 3.99;
                        Cupcake.Size = "Standard";
                        Toppings.ToppingsOpening();
                        break;
                    }
                case "3":
                    {
                        Cupcake.Total += 6.99;
                        Cupcake.Size = "Maxi";
                        Toppings.ToppingsOpening();
                        break;
                    }
            }
        }

        public static void DeluxeRedVelvet()
        {
            string price;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Red velvet, very fancy.\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("We have 3 sizes:");
            Console.WriteLine("1. Mini-$2.99");
            Console.WriteLine("2. Standard-$4.99");
            Console.WriteLine("3. Maci-$7.99");

            price = Console.ReadLine();

            switch (price)
            {
                case "1":
                    {
                        Cupcake.Total += 2.99;
                        Cupcake.Size = "Mini";
                        Toppings.ToppingsOpening();
                        break;
                    }
                case "2":
                    {
                        Cupcake.Total += 4.99;
                        Cupcake.Size = "Standard";
                        Toppings.ToppingsOpening();
                        break;
                    }
                case "3":
                    {
                        Cupcake.Total += 7.99;
                        Cupcake.Size = "Maxi";
                        Toppings.ToppingsOpening();
                        break;
                    }
            }
        }

        public static void LimitedEditionEspressoSupreme()
        {
            string price;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Carful now, eat it all and you will be up for a week.\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("We have 3 sizes:");
            Console.WriteLine("1. Mini-$3.50");
            Console.WriteLine("2. Standard-$5.50");
            Console.WriteLine("3. Maci-$8.50");

            price = Console.ReadLine();

            switch (price)
            {
                case "1":
                    {
                        Cupcake.Total += 3.50;
                        Cupcake.Size = "Mini";
                        Toppings.ToppingsOpening();
                        break;
                    }
                case "2":
                    {
                        Cupcake.Total += 5.50;
                        Cupcake.Size = "Standard";
                        Toppings.ToppingsOpening();
                        break;
                    }
                case "3":
                    {
                        Cupcake.Total += 8.50;
                        Cupcake.Size = "Maxi";
                        Toppings.ToppingsOpening();
                        break;
                    }
            }
        }
        
    }
}