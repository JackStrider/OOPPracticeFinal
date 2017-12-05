using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void Main(string[] args)
        {
            float Total;
            string Kind;
            string Size;

            int ChocolateSauce;
            int CaramelDrizzle;
            int Sprinkles;
            int ChocolateChips;
            int Coconut;

            WelcomeMessage.welcomeMessage();
            Menu.menu();
        }
    }
}
