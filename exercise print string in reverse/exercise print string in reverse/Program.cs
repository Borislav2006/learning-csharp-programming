using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_print_string_in_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type something: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]); 
            }
            Console.Write("-");
            for (int i = text.Length - 1; i >=0; i--)
            {
                Console.Write(text[i]);
            }

            Console.ReadLine();
        }
    }
}
