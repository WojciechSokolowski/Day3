using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07Enumerators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a city");
            string city = Console.ReadLine();



            List<Unit> units = Enum.GetValues(typeof(Unit)).Cast<Unit>().ToList();

            Console.WriteLine("Enter one of the following units " +
                string.Join(", ", units));

            string unit = Console.ReadLine();

            bool isValid = Enum.TryParse(unit, out Unit unitenum);

            Unit selectedUnit = (Unit)Enum.ToObject(typeof(Unit), 2 - 1);
            if (isValid )
            {
                WeatherManager weatherManager = new WeatherManager();
                double temp = weatherManager.GetTemperature(city, unitenum);
                Console.WriteLine(temp);
            }



            //ctrrl + space show tips
            

        }
    }
}
