using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            string userName;
            string emAddress;
            string phNumber;
            string date;
            bool doesNameMatch;
            bool doesEmailMatch;
            bool doesPhoneMatch;
            bool doesDateMatch;


            //get info
            Console.Write("Please enter a valid name: ");
            userName = Console.ReadLine();


            Console.Write("Please enter a valid email address: ");
            emAddress = Console.ReadLine();


            Console.Write("Please enter a valid number (format xxx-xxx-xxxx): ");
            phNumber = Console.ReadLine();


            Console.Write("Please enter a date (format dd/mm/yyyy): ");
            date = Console.ReadLine();


            //call name method verifyName
            doesNameMatch = VerifyName(userName);
            if(doesNameMatch)
            {
                Console.WriteLine("Name is valid!");
            }
            else
            {
                Console.WriteLine("Name is not valid.");
            }


            

            //call email method verifyEmail
            doesEmailMatch = VerifyEmail(emAddress);
            if (doesEmailMatch)
            {
                Console.WriteLine("Email matches!");
            }
            else
            {
                Console.WriteLine("Email does not match.");
            }

            //call phone method verifyPhone
            doesPhoneMatch = VerifyPhNumber(phNumber);
            if (doesPhoneMatch)
            {
                Console.WriteLine("Phone number is valid!");
            }
            else
            {
                Console.WriteLine("Phone number is not valid.");
            }

            //call date method verifyDate
            doesDateMatch = VerifyDate(date);
            if (doesDateMatch)
            {
                Console.WriteLine("The date is valid!");
            }
            else
            {
                Console.WriteLine("The date is not valid.");
            }
        }


        //name method
        static bool VerifyName(string x)
        {
            //Starts with capital
            //alpha only
            //max length of 30 chars
            if (Regex.IsMatch(x, @"^[A-Z][a-z]{0,29}$"))
            {
                return (true);
            }
            else
            {
                return (false);
            }
            
        }

        //email method
        static bool VerifyEmail(string x)
        {
            //Alpha-numeric
            //no special characters
            //min/max length of 5-30 chars
            //domain of 2-3 chars
            if (Regex.IsMatch(x, @"^[A-Z 0-9._-]+@[A - Z 0-9.-]+\.[A-Z]{2,}$"))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        //phone method
        static bool VerifyPhNumber(string x)
        {
            //All numbers
            //3 3 and 4
            if (Regex.IsMatch(x, @"^[1-9]\d{2}-\d{3}-\d{4}$"))
            {
                return (true);
            }
            else
            {
                return (false);
            }

        }

        //date method
        static bool VerifyDate(string x)
        {
            //numbers only
            //2 2 and 4
            if (Regex.IsMatch(x, @"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$"))
            {
                return (true);
            }
            else
            {
                return (false);
            }

        }
    }
}
