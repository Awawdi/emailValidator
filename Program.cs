using System;
using System.Text.RegularExpressions;
namespace start
{
    class Program
    {
        static void Main(string[] args)
        {
            Implementation emailChecker = new Implementation();
            Console.WriteLine("Please enter your email address to verify");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("checking email address : "+ emailAddress);
            Console.WriteLine(emailChecker.callValidator(emailAddress));
            
        }

        public class Implementation
        {
        public String callValidator(string userEmail)
        {
        Regex emailRegex = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        bool valid = true;        
        String Message="";

        if (userEmail.Length == 0)
        {
            Message += "you must enter an email address";
            valid = false;
        }

        if (!emailRegex.IsMatch(userEmail))
        {
            Message = "email address is invalid";
            valid = false;
        }

        if (!valid)
            return Message;
            else
            return "Email Address is correct!";
        }
        }
    }
}