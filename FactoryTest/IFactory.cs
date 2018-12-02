using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    public interface IFactory
    {
        Class1 Create();
        Class1 Create(string pggg);
    }
}
