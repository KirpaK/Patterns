using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative.Builder
{
    abstract class Builder
    {
        public abstract Builder BuildPartA();

        public abstract Builder BuildPartB();

        public abstract Builder BuildPartC();

        public abstract Product GetProduct();
    }
}
