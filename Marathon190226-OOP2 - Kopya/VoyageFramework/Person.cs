using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string IdentityNumber { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        private const int daysInYear = 365;
        public int Age
        {            
            get
            {                
                return (DateTime.Now - DateOfBirth).Days / daysInYear;  
            }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
