using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_sum_of_int_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0,1, 2, 3, 4, 5,
            };

            int result = SumOfTwoNumbers(numbers);

            if(result > -1)
            {
                Console.WriteLine($"The total is : {result}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array!");
            }

            if(SumOfTwoNumbers(numbers,out int total))
            {
                Console.WriteLine($"The total is : {total}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array!");
            }

            Console.ReadLine();
        }
        static int SumOfTwoNumbers(int[] numbers)
        {
            
            if(numbers.Length > 0)
            {
                int total = 0;

                foreach (var item in numbers)
                {
                    total += item;
                }

                return total;
            }
            return -1;
        }

        static bool SumOfTwoNumbers(int[] numbers, out int total)
        {
           total = 0;
            if (numbers.Length > 0)
            {

                foreach (var item in numbers)
                {
                    total += item;
                }

                return true;
            }
            return false;
        }
    }
}
