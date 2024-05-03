using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public partial class Person
    {
        public Person(string firstName, string lastName, DateOnly dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
        }
        public int GetAge()
        {
            var age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.Month < DateOfBirth.Month)
            {
                age--;
            }
            else if (DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day)
            {
                age--;
            }

            return age;
        }

        public int GetAge(int year)
        {
            var age = year - DateOfBirth.Year;
            return age;
        }
    }
}
