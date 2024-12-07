using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_fizz_buzz_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool threeDiv = false;
            bool fiveDiv = false;

            for (int i = 1; i <=15; i++)
            {
                threeDiv = i % 3 == 0; 
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv )
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 1)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0) 
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
