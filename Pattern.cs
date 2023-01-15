using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationDetails
{
    public class Pattern
    {
        public static void FirstName()     //UC1
        {
            Console.WriteLine("Enter the First Name ");
            string firstName = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z]{2,}$";
            Iteration(firstName, regexCondition);
        }
        public static void LastName()      //UC2
        {
            Console.WriteLine("Enter your Last Name");
            string userInput = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z]{3,}$";
            Iteration(userInput, regexCondition);
        }
        public static void Iteration(string firstName,string regexCondition)
        {
            if (Regex.IsMatch(firstName, regexCondition))
            {
                Console.WriteLine("Validated Successfully");
            }
            else
            {
                Console.WriteLine("Pattern is not Matching....Try Again!");
            }
        }    
    }
}
