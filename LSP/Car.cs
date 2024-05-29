using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID101.LSP
{
    public class Car : Vehicle, IEnginePowered
    {
        public void StartEngine()
        {
            Console.WriteLine("Starting the car engine.");
            // Code to start the car engine
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping the car engine.");
            // Code to stop the car engine
        }
    }
}
