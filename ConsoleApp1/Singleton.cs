using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        static Singleton()
        {
        }

        public static Singleton Instance
        {
            get { return _instance;  }
        }
    }
}
