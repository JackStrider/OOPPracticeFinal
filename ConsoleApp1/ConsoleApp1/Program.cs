using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public int Total;
        public string Flavor;

        static void Main(string[] args)
        {
            WelcomeMessage.welcomeMessage();
            Menu.menu();
        }
    }
}
