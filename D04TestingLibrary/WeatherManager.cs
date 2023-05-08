using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace D04TestingLibrary
{
    //enumerators are distinct type consisting elements
    //if we put it inside class we can not use it public methods
    public enum Unit
    {
        // Celsius =5,
        Celsius,
        Kelvin,
        Fahrenheit
    }

    public class WeatherManager
    {
        private Unit unit;
            public string SearchChar { get; } = "°"; //removing set conwerts to read only property
            public string EndChar { get; set; } = ">"; // full access property

            // private field
            private string url = $"https://www.google.com/search?q=weather+"; //storing it outside makes code cleaner

        public WeatherManager()
        {
            unit = Unit.Celsius;
        }

        public WeatherManager(Unit unit)
        {
            this.unit = unit;
        }

        public double GetTemperature(string city)
        {

            WebClient myWebClient = new WebClient();

            //do not use interface instruction inside classes because 
            // if me make library for many types of aplications it will be unusable
            //Console.WriteLine("Give name of the city");
            //string city = Console.ReadLine();

            string data = myWebClient.DownloadString(url + city);
            string temperature = "";
            




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
