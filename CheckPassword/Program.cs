using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassword
{
    class Program
    {
        static string userPassword;


        static void Main()
        {
            // password 
            // let the user input a password.
            // save that password.
            // ask user to input password.
            // give a message or its correct or not.

            AskUserForPassword();

            Console.ReadKey();
        }

        private static void AskUserForPassword()
        {
            Console.WriteLine("Please input your new password.");
            
            UserPassword();
        }



        private static void UserPassword()
        {
            userPassword = Convert.ToString(Console.ReadLine());

            
            if (userPassword.Length < 4 || userPassword.Length > 10 )
            {
                Console.WriteLine("The password must be between 4 and 10 characters!!");
                Console.WriteLine("--------------------------------------------------");
                AskUserForPassword();
            }
            else
            {
                InputPasswordToLogIn(userPassword);
            }            
        }

        private static void InputPasswordToLogIn(string passwordCheck)
        {
            Console.Clear();

            Console.WriteLine("Please input your password to log in");

            string input = Convert.ToString(Console.ReadLine());

            if (passwordCheck == input)
            {
                Console.WriteLine("Log in succesfull, Welcome.");
            }
            else
            {
                Console.WriteLine("Your Password is incorrect! \nPlease try again.");
                InputPasswordToLogIn(userPassword);
            }

             
        }
    }
}
