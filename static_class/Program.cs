using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class
{
    static class MyClass
    {
        static MyClass()
        {
            
        }

        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Foo();
        }
    }
}
