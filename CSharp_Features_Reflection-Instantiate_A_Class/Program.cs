using System;
using System.Reflection;

namespace CSharp_Features_Reflection_Instantiate_A_Class
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;

    namespace ReflectionTest
    {

        /***
         * So far, we have worked with .NET types or objects already instantiated. But with Reflection, we can actually do the instantiation at runtime as well, knowing the name of the class 
         * we wish to instantiate. There are several ways of doing it, but I prefer getting a reference to the constructor that I wish to use, invoke it, and then use the returned value as 
         * my instance.
         */
        class Program
        {
            static void Main(string[] args)
            {
                Type testType = typeof(TestClass);
                ConstructorInfo ctor = testType.GetConstructor(System.Type.EmptyTypes);
                if (ctor != null)
                {
                    object instance = ctor.Invoke(null);
                    MethodInfo methodInfo = testType.GetMethod("TestMethod");
                    Console.WriteLine(methodInfo.Invoke(instance, new object[] { 10 }));
                }
                Console.ReadKey();
            }
        }

        public class TestClass
        {
            private int testValue = 42;

            public int TestMethod(int numberToAdd)
            {
                return this.testValue + numberToAdd;
            }
        }
    }
}
