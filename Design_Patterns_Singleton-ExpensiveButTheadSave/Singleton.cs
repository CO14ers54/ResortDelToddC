using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_Singleton_ExpensiveButTheadSave
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public string ILoveTheSingleton()
        {
            return "This Singleton Loves You!";
        }
    }
}
