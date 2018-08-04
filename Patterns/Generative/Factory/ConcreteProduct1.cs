using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative.Factory
{
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
