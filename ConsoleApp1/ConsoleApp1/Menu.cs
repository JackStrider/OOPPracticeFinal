﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {

        public static void menu()
        {
            string Type;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            //gives a different starting phrase incase the player came back to make another cupcake
            if (Cupcake.Total == 0) 
            Console.WriteLine("As you read the words in the book, they begin to narrate themselves.\n");
            else
            Console.WriteLine("You return to the book and it begins to read again");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Lets begin with what flavor your in the mood for");
            Console.WriteLine("We have:");
            Console.WriteLine("1. Original Vanilla");
            Console.WriteLine("2. Chocolate");
            Console.WriteLine("3. Deluxe Red Velvet");
            Console.WriteLine("4. Limited Edition Espresso Supreme/n");
            Console.WriteLine("Just say the number you want, I'm magic, I can hear you.(type and hit enter)");

            Type = Console.ReadLine();
            switch(Type)
            {
                case "1":
                    {
                        Cupcake.Kind = "Original Vanilla";
                        Flavor.OriginalVanilla();
                    break;
                    }
                case "2":
                    {
                        Cupcake.Kind = "Chocolate";
                        Flavor.Chocolate();
                        break;
                    }
                case "3":
                    {
                        Cupcake.Kind = "Deluxe Red Velvet";
                        Flavor.DeluxeRedVelvet();
                        break;
                    }
                case "4":
                    {
                        Cupcake.Kind = "Limited Edition Espresso Supreme";
                        Flavor.LimitedEditionEspressoSupreme();
                        break;
                    }
            }

        }
    }
}