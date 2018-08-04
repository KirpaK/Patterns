using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative.Builder
{
    class ConcreteBuilder : Builder
    {
        Product product = new Product();

        public override Builder BuildPartA()
        {
            product.Add("PartA1");
            return this;
        }

        public override Builder BuildPartB()
        {
            product.Add("PartB1");
            return this;
        }

        public override Builder BuildPartC()
        {
            product.Add("PartC1");
            return this;
        }

        public override Product GetProduct()
        {
            Product result = product;

            this.Reset();

            return result;
        }

        public void Reset()
        {
            product = new Product();
        }
    }
}
