using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class Driver : Person
    {
        public int DriverId { get; set; }
        public LicenseType LicenseType { get; set; }

        public Driver(string firstName,string lastName,LicenseType licenseType,DateTime dateOfBirth) : base(firstName,lastName)
        {
            const int MinDriverAge = 25;
            DateOfBirth = dateOfBirth;
            LicenseType = licenseType;
            if (Age< MinDriverAge)
            {
                throw new Exception("Sürücülerin yaşı minumum 25 olmalı..");
            }           
        }        
    }
}
