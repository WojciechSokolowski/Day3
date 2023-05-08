using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- example 1 -----");
            Calculator calculator = new Calculator("normal");

            //calculator.Mode = "normal";
            double d = calculator.Calculate(2, 3);

            Calculator c2 = new Calculator(); //if commented constuctor cant do it
            
            
            Console.WriteLine("----- example 2 -----");

            WeatherManager weatherManager = new WeatherManager();
            weatherManager.GetTemperature("Warsaw");
            weatherManager.GetTemperature("Singapore");

        }
    }
}
