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
    }
}
