using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Constructor");
        }

        static MyClass()//static constructor initialized once only,
        {
            Console.WriteLine("Static constructor");
        }

        public static void Foo()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();

            new MyClass();
            new MyClass();
            new MyClass();

        }
    }
}
