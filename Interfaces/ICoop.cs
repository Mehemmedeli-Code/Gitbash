using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Interfaces
{
    internal interface ICoop
    {
        public bool IsKeyboardAllowed { get; set; }

        public static bool StartCoop(bool startCoop)
        {
            if (startCoop) 
            {
                Console.WriteLine("co-op oyun basladildi");
                return true;
            }
            return false;
        }
    }
}
