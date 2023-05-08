using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08PropertiesAndFields
{
    internal class Person
    {
        public string FirstName { get; set; } //property is pubic written with big lette
        private string lastName; //fields are private written with small letter

        public string LastName
        {
            get {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                string upperFirstName =FirstName.ToUpper();
                string lowerLastName = LastName.ToLower();
                return FirstName + " " + LastName;
            }
            
        }
    }
}
