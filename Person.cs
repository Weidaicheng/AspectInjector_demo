using System;

namespace AspectInjector_demo
{
    public class Person
    {
        [LogCall]
        public string Name { get; set; } = "Weidaicheng";
    }
}