using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_area_of_a_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = ReadInt("Enter width: ");
            int height = ReadInt("Enter height: ");
            
            int result = CalArea(width, height);
            Console.WriteLine($"The area is {result}");

            Console.ReadLine();
        }
        static int CalArea(int width, int height)
        {
            return (width * height)/2;
        }
        static int ReadInt(string message)
        {
            Console.Write($"Enter {message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
