using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C07Enumerators
{
    //enumerators are distinct type consisting elements
    //if we put it inside class we can not use it public methods
    enum Unit
    {
        // Celsius =5,
        Celsius,
        Kelvin,
        Fahrenheit
    }

    internal class WeatherManager
    {
        public double GetTemperature(string city, Unit unit)
        {

            WebClient myWebClient = new WebClient();

            //do not use interface instruction inside classes because 
            // if me make library for many types of aplications it will be unusable
            //Console.WriteLine("Give name of the city");
            //string city = Console.ReadLine();

            string url = $"https://www.google.com/search?q=weather+{city}";
            string data = myWebClient.DownloadString(url);
            string temperature = "";
            string SearchChar = "°";
            string EndChar = ">";





            try
            {
                int DegreeIndex = data.IndexOf("°");
                int Index = DegreeIndex;
                while (data.Substring(Index, 1) != ">")
                {
                    Index--;
                }
                temperature = data.Substring(Index + 1, DegreeIndex - Index + 1);
            }
            catch (Exception)
            {
                Console.WriteLine("failed to retrieve temp");
            }
            return TransformTemperature(unit, Convert.ToDouble(temperature.Substring(0, temperature.Length - 2)));


        }

        private double TransformTemperature(Unit unit, double temperature)
        {
            if (unit == Unit.Celsius)
                return temperature;
            if (unit == Unit.Fahrenheit)
                return temperature * 1.8 + 32;
            if (unit == Unit.Kelvin)
                return temperature + 273.15;
            throw new Exception("Unknown Unit");
        }

    }
}
