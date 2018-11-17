using System;
using System.Collections.Generic;
using System.Text;

namespace TestModule
{
    public class IoCModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Console.WriteLine("    Loaded IoCModule");

            Bind<object>().To<Class1>().InSingletonScope();
        }
    }
}
