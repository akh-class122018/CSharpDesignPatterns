using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGenerator

    {
        //private = access modifier that restrict acess to the class only., 
        //static - no intances of this variable are created. It is only 1.
        //volatile - one path might be split among different paths, 
        // may be modified by multiple threads that are being executed at the same time

        private static volatile SerialNumberGenerator instance;

        // object - root of all ogjects in .Net
        private static object synchronizationRoot = new object();

        private int _count = 12345;

        // property of the class SerialNumberGenerator that is read-only, no set
        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialNumberGenerator() { }

        //property of int
        public int NextSerial
        {
            get { return ++_count; }
        }
    }
}
