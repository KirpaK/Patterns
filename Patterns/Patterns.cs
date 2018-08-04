using System;

namespace Patterns
{
    public class Pattern
    {
        public void StartSingleton()
        {
            var client = new Generative.Singleton.Client();
            client.ClientCode();
        }

        public void StartBuilder()
        {
            var client = new Generative.Builder.Client();
            var builderA = new Generative.Builder.ConcreteBuilder();
            var director = new Generative.Builder.Director(builderA);
            client.ClientCode(director, builderA);
        }
    }
}
