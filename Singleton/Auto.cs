using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Das Auto als Beispiel als Singleton ausgeführt
    public class Auto
    {
        private static Auto InstanceObjekt = null;

        private Auto()
        {

        }

        public static Auto getInstance()
        {
            if (InstanceObjekt == null)
            {
                InstanceObjekt = new Auto();
                return InstanceObjekt;
            }
            return InstanceObjekt;
        }

        public void Geschwindigkeit()
        {
            Console.WriteLine("Das Auto fährt mit 100km/h...");
        }

        public void Farbe()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Das Auto ist rot");
        }

    }
}
