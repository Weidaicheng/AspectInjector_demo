using System;
using System.Reflection;
using AspectInjector.Broker;

namespace AspectInjector_demo
{
    [AttributeUsage(AttributeTargets.Property)]
    [Aspect(Scope.Global)]
    [Injection(typeof(LogCall))]
    public class LogCall : Attribute
    {
        [Advice(Kind.Before)]
        public void LogEnter([Argument(Source.ReturnType)]Type rType)
        {
            if(rType != typeof(void))
                Console.WriteLine($"return Type: {rType.FullName}");
        }
    }
}