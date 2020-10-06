using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationValidationProgram
{
    class UserData
    {
        public string firstName, lastName, eMail, phoneNum, password;

        public void EnterFirstName()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            this.firstName = firstName;
        }
        
        public void EnterLastName()
        {
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            this.lastName = lastName;
        }

        public void EnterEmail()
        {
            Console.WriteLine("Enter email ID:");
            string eMail = Console.ReadLine();
            this.eMail = eMail;
        }

        public void EnterPhoneNumber()
        {
            Console.WriteLine("Enter Phone Number:");
            string phoneNumber = Console.ReadLine();
            this.phoneNum = phoneNumber;
        }

        public void EnterPassword()
        {
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            this.password = password;
        }
    }
}
