using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 100);
            int userEnetry;
            int tries = 0;
            bool again = true;
            while (again)
            {
              
                Console.WriteLine("Please enter a number between 1 - 100");
                userEnetry = Convert.ToInt32(Console.ReadLine());
                if (userEnetry > r)
                {
                    Console.WriteLine("Hey buddy that number is too high!!!");
                }
                else if (userEnetry < r)
                {
                    Console.WriteLine("Hey pal that number is low!!!");
                }
                else if (userEnetry == r)
                {
                    Console.WriteLine("That number is spot on!!!");

                }
                tries = tries + 1;
                if (tries == 6)
                {
                    Console.WriteLine("Go back to your day job too many tries = " + tries + 
                        "\n answer was " + r);
                    again = false;
                }
            }
        }
   
       
    }
}
