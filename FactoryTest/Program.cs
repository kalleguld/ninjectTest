using System;
using Ninject;
using Ninject.Extensions.Factory;

namespace FactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new FuncModule());
            kernel.Bind<Class1>().ToSelf();
            kernel.Bind<Class2>().ToSelf();
            kernel.Bind<IFactory>().ToFactory(() 
                => new TypeMatchingArgumentInheritanceInstanceProvider());
            var factory = kernel.Get<IFactory>();


            var c1 = factory.Create("asfd");



            var objString = c1.ToString();
            
            Console.WriteLine(objString);

            Console.ReadKey();
        }
    }
}
