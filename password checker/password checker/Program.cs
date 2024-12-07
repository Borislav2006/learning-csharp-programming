using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your password: ");
            string password1 = Console.ReadLine();

            Console.Write("Type it again: ");
            string password2 = Console.ReadLine();

            if (!password1.Equals(string.Empty))
            {
                if (!password2.Equals(string.Empty))
                {
                    if (password1.Equals(password2))
                    {
                        Console.WriteLine("Passwords match");
                    }

                    else
                    {
                        Console.WriteLine("Password do not match");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a password confirmation.");
                }

            }
            else
            {
                Console.WriteLine("Please enter a password");
            }

            Console.ReadLine();
        }
    }
}
