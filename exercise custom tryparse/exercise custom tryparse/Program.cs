using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_custom_tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            if(TryParse(Console.ReadLine(),out int result))
            {
                Console.WriteLine("Yey "+ result);
            }
            else
            {
                Console.WriteLine("Oh no");
            }
            Console.ReadLine();
        }
        static bool TryParse(string input,out int result)
        {
            result =-1;
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
            return false;
            }
        }
    }
}
