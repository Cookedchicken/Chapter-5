using System;

namespace SumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            public static void DisplayForLoops() {
            }          
            int total = 0;
            int entry;
            for (int g= 0; g < 15; ++g   ) {
                Console.WriteLine("Enter a number");
                entry = Convert.ToInt32(Console.ReadLine());
                total = entry + total;
            }
            Console.WriteLine("The total is ");
        }
        public static void DisplayWhileLoop()
        {
            int entry;
            int i = 0;
            int total = 0;
            while (i < 4) {
            }
            Console.WriteLine("Please enter a number >>>>");
            entry = Convert.ToInt32(Console.ReadLine());
            total = total + entry;
            i++;
        }
        Console.WriteLine(total);
        
        public static void DisplayDoWhile() {
        }
     
        
    }
}
