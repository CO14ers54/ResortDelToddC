using System;
using System.Reflection;


namespace CSharp_Features_Reflection_Simple2
{
    /***
     * The Type class is the foundation of Reflection. It serves as runtime information about an assembly, a module or a type. Fortunately, obtaining a reference to the Type of an object 
     * is very simply, since every class that inherits from the Object class, has a GetType() method. If you need information about a non-instantiated type, you may use the globally 
     * available typeof() method, which will do just that.
     * 
     * At some point, you might even only have the name of the type that you're looking for. In that case, you will have to get a reference to it from the proper assembly. In the next 
     * example, we get a reference to the executing assembly, that is, the assembly from where the current code is being executed from, and then we list all of it's types:
     */

    class Program
    {
        static void Main(string[] args)
        {
            string test = "test";
            Console.WriteLine(test.GetType().FullName);
            Console.WriteLine(typeof(Int32).FullName);
            Console.WriteLine();

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] assemblyTypes = assembly.GetTypes();
            foreach (Type t in assemblyTypes)
                Console.WriteLine(t.Name);
            Console.ReadKey();
        }
    }

    class DummyClass
    {
        //Just here to make the output a tad less boring :)
    }
}
