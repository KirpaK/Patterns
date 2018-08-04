using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative.Builder
{
    class Product
    {
        List<object> parts = new List<object>();

        public void Add(string part) => parts.Add(part);

        public string ListParts() => $"Product parts: {String.Join(", ", parts)}\n";
    }
}
