using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative.Prototype
{
    class ComponentWithBackReference
    {
        public Prototype Prototype { get; set; }

        public ComponentWithBackReference(Prototype p)
        {
            Prototype = p;
        }
    }
}
