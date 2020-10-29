using System;

namespace Design_Patterns_Singleton_ExpensiveButTheadSave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I Love Singletons!");
            Singleton sing = Singleton.Instance;
            Console.WriteLine(sing.ILoveTheSingleton());
            Console.ReadLine();
        }
    }
}
