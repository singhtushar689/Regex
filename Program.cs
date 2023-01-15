using System;

namespace UserRegistrationDetails
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select any one from below :\n" +
              "Press 1 : To Register your First Name.\n" +
              "Press 2: To Register your Last Name \n" + 
              "Press 3: To enter your Email ID .\n" +
              "Press 4: To enter Your Mobile Number \n" + 
              "Press 5 :To enter Minimun 8 Char Password \n" +
              "Press 6: To Enter Atleast 1Upper case Password \n" + 
              "Press 7: To Enter PassWord With 1Numeric\n" +
              "Press 8: To Enter Special Character \n" + 
              "Press 9: To Enter EmailId Sample");
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
                case 4:
                    Pattern.MobileNumber();
                    break;
                case 5:
                    Pattern.PassMin8Char();
                    break;
                case 6:
                    Pattern.PassMin8CharAnd1UpperCase();
                    break;
                case 7:
                    Pattern.UpperCase1AndNumeric1();
                    break;
                case 8:
                    Pattern.SpecialCharacter1();
                    break;
                case 9:
                    Pattern.EmailSample();
                    break;
                default:
                    Console.WriteLine("Enter valid option ...try again!");
                    break;
            
            }
        }
    }
}