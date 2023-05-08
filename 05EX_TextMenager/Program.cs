using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05EX_TextMenager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //what is var?

            string a = "john";
            int b = 4;

            var c = "john";
            var d = 5;

            //not efficient
            dynamic e = 5;
            e = "john";

        }
    }
}
