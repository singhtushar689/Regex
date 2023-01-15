using System;

namespace UserRegistrationDetails
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Given Option below: \n" +
                 " 1.Enter the First Name ");   
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option) 
            {
                case 1:
                    Pattern.FirstName();
                    break;
                default:
                    Console.WriteLine("Enter valid option ...try again!");
                    break;
            
            }
        }
    }
}