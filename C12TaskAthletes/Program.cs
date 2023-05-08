using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C12TaskAthletes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerManager manager = new PlayerManager();
            Player[] players = manager.LoadPlayers();

            foreach (Player player in players)
            {
                Console.WriteLine(player.FullName);
            }

            Console.ReadKey();
        }


    }
}

