using System;

namespace FactoryTest
{
    public class Class1
    {
        private readonly Class2 f;

        public Class1(Class2 f)
        {
            Console.WriteLine("    TestModule Ctor");
            this.f = f;
        }

        public override string ToString()
        {
            return "Class1 toString t2" + f.ToString();
        }
    }
}
