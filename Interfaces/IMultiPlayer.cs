using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Interfaces
{
    internal interface IMultiPlayer
    {
        public int MaxPlayers { get; set; }

        public static bool StartMultiplayer(bool startMultiplayer)
        {
            if (startMultiplayer)
            {
                Console.WriteLine("multiplayer oyun basladildi");
            }
            return false;
        }
    }
}
