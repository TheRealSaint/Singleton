using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Allgemeiner Code eines Singleton (Lazy Loading)
    public class Singleton
    {
        private static Singleton InstanceObjekt = null;

        private Singleton()
        {

        }

        public static Singleton getInstance()
        {
            if (InstanceObjekt == null)
            {
                InstanceObjekt = new Singleton();
                return InstanceObjekt;
            }
            return InstanceObjekt;
        }
    }
}
