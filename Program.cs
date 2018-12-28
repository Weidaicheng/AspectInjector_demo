using System;

namespace AspectInjector_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Jonathan";
            Console.WriteLine(p.Name);
        }
    }
}
