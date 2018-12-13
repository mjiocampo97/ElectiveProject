using System;
using System.Collections.Generic;
using System.Text;
using OcampoElective2Project.Helpers;

namespace OcampoElective2Project.Models
{
   public class Account : OcampoElective2ProjectViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }      
        public double Money { get; set; }
        public double Income { get; set; }
        public string Password { get; set;}
        public string EmailAdress { get; set; }

        public Account(string firstName, string lastName, DateTime birthDate, double money, double income, string password, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Money = money;
            Income = income;
            Password = password;
            EmailAdress = emailAddress;
        }

        public Account()
        {
            
        }
        
    }
}
