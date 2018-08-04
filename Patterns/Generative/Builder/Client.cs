using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative.Builder
{
    class Client
    {
        public void ClientCode(Director director, Builder builder)
        {
            Console.WriteLine("Standart basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standart full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product:");
            builder.BuildPartA().BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}
