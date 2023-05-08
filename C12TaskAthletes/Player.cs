using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12TaskAthletes
{
    internal class Player
    {
        public int PlayerNumber { get; set; }

        public int CoachID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }

        public DateTime Birthday { get; set; }

        public int Heigth { get; set; }

        public int Weight { get; set; } 

        public string FullName
        {
            get
            {
                return FirstName+ " " + LastName;
            }
        }
    }
}
