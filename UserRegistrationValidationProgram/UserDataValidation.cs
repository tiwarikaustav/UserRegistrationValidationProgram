using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidationProgram
{
    class UserDataValidation
    {
        public static string firstNameRegex = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string lastNameRegex = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string eMailRegex = "^[a-z0-9]+[.a-z0-9]*[@][a-z]+[.][a-z]+[.a-z]*$";
        public static string phoneNumberRegex = "^[0-9]{2}[ ][0-9]{10}$";
        public static string passwordRegex = "^[A-Za-z0-9]{8,}$";

        public void IsValidFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, firstNameRegex)) 
            {
                Console.WriteLine("First Name Validated.");
            }
            else Console.WriteLine("Invalid Entry!");
        }

        public void IsValidLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, lastNameRegex))
            {
                Console.WriteLine("Last Name Validated.");
            }
            else Console.WriteLine("Invalid Entry!");
        }
        public void IsValidEmail(string email)
        {
            if (Regex.IsMatch(email, eMailRegex))
            {
                Console.WriteLine("EMail Validated.");
            }
            else Console.WriteLine("Invalid Entry!");
        }
        public void IsValidPhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, phoneNumberRegex))
            {
                Console.WriteLine("Phone Number Validated.");
            }
            else Console.WriteLine("Invalid Entry!");
        }
        public void IsValidPassword(string password)
        {
            if (Regex.IsMatch(password, passwordRegex))
            {
                Console.WriteLine("Password Validated.");
            }
            else Console.WriteLine("Invalid Entry!");
        }

    }
}
