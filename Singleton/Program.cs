using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            Auto TestAuto = Auto.getInstance();
            Console.WriteLine("***Auto #1 ***");
            TestAuto.Farbe();
            TestAuto.Geschwindigkeit();

            Auto TestAuto2 = Auto.getInstance();
            Console.ForegroundColor = ConsoleColor.White;            
            Console.WriteLine("***Auto #2 ***");
            TestAuto2.Farbe();
            TestAuto2.Geschwindigkeit();
            
            Console.ReadLine();
        }
    }
}
