using System;
using Ninject;

namespace NinjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load("./modules/*.dll");
            var obj = kernel.Get<object>();
            var objString = obj.ToString();
            var standardObjString = (new object()).ToString();

            var testSuccess = objString != standardObjString;
            Console.WriteLine("Test Success: " + testSuccess);
            

            Console.ReadKey();
        }
    }
}
