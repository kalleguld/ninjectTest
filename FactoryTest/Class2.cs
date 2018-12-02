using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    public class Class2
    {
        private readonly string p;

        public Class2(string p)
        {
            this.p = p;
        }

        public override string ToString()
        {
            return "Class2 " + p;
        }
    }
}
