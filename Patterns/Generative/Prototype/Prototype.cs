using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative.Prototype
{
    class Prototype
    {
        public int Primitive { get; set; }

        public DateTime Component { get; set; }

        public ComponentWithBackReference CircularReference { get; set; }

        public Prototype()
        { }

        public Prototype Clone()
        {
            return CircularReference.Prototype;
        }
    }
}
