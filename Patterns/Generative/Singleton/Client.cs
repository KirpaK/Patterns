using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative.Singleton
{
    class Client
    {
        public void ClientCode()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
