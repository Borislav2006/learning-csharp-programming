﻿//using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_times_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("type a number: ");
            int num = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i,num, i * num);
            }
            Console.ReadLine();
        }
    }
}
