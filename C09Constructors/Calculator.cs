using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09Constructors
{
    internal class Calculator
    {
        private string mode;
        //ctor shortcut

        public Calculator()
        {
            mode = "scientific";
        }

        public Calculator(string mode)
        {
            // this. refers to the body of the class
            this.mode = mode; 
        }


        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        public double Calculate(double a, double b)
        {
            if (mode == "normal")
                return a + b;
            if (mode == "scientific")
            {
                return a + b;
            }
            throw new Exception("unknown mode");


        }



    }
}
