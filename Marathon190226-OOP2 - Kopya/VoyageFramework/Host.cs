using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class Host : Person
    {
        public int HostId { get; set; }
        public Host(string firstName, string lastName, DateTime dateOfBirth) : base(firstName, lastName)
        {
            const int MinHostAge = 18;
            DateOfBirth = dateOfBirth;
            if (Age < MinHostAge)
            {
                throw new Exception("Muavinin yaşı minimum 18 olmalıdır..");
            }
        }
    }
}
