using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace YearValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter your year of birth");
                string userInput = Console.ReadLine();

                if (Validate(userInput))
                {

                }
            }
        }

        public static bool Validate(string yearinput)
        {
            if(yearinput.Length == 4)
            {
                try
                {
                    Int32.Parse(yearinput);
                    Console.WriteLine("All good");
                    return true;
                } catch(Exception error)
                {
                    Console.WriteLine(error);
                    return false;
                }
            } else
            {
                Console.WriteLine("Ooops something went wrong.");
                return false;
            }
        }
        public static void CalculateAge(string yearInput)
        {
            int year = Int32.Parse(yearInput);

            DateTime now = DateTime.Now;
            string currentyear = now.Year.ToString();
            int yearNow = Int32.Parse(currentyear);
            int age = yearNow - year;
            Console.WriteLine($"You are {age} years old");
        }
        
    } 
}

