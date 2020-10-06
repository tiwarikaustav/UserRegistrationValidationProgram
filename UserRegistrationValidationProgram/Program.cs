using System;

namespace UserRegistrationValidationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Data Validation Program!");
            UserData userData = new UserData();
            UserDataValidation userDataValidation = new UserDataValidation();
            userData.EnterFirstName();
            userDataValidation.IsValidFirstName(userData.firstName);
        }
    }
}
