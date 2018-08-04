using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative.Builder
{
    class Director
    {
        Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void BuildMinimalViableProduct() => builder.BuildPartA();

        public void BuildFullFeaturedProduct() => builder.BuildPartA().BuildPartB().BuildPartC();
    }
}
