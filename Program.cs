﻿using System;

namespace UserRegistrationDetails
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select any one from below :\n" +
              "Press 1 : To Register your First Name.\n" +
              "Press 2: To Register your Last Name \n" + "Press 3: To enter your Email ID .\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option) 
            {
                case 1:
                    Pattern.FirstName();
                    break;
                case 2:
                    Pattern.LastName();
                    break;
                case 3:
                    Pattern.EmailID();
                    break;
                default:
                    Console.WriteLine("Enter valid option ...try again!");
                    break;
            
            }
        }
    }
}