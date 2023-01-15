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
        public static void EmailID()
        {
            Console.WriteLine("Enter your Email ID");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            Iteration(userInput, regexCondition);
        }
        public static void MobileNumber()      //UC4
        {
            Console.WriteLine("Enter your Mobile Number");
            string userInput = Console.ReadLine();
            string regexCondition = "^[9]{1}[1]{1}[ ]{1}[1-9]{1}[0-9]{9}$";
            Iteration(userInput, regexCondition);
        }
        public static void PassMin8Char()      //UC5
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-zA-Z0-9]{8,}$";
            Iteration(userInput, regexCondition);
        }
        public static void PassMin8CharAnd1UpperCase() //UC6 (min 8 char and atleast 1 upper case in it.
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^(?=.*[A-Z]).{1,}[a-zA-Z0-9]{7,}$";
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
