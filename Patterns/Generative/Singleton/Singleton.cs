using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative.Singleton
{
    class Singleton
    { 
        private static Singleton instance;
        private static object thislock = new object();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            lock (thislock)
            {
                if (instance == null) instance = new Singleton();
                return instance;
            }
        }
    }
}
