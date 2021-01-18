using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
    class MyClass
    {
        private static int b;

        public void SetB(int b)
        {
            MyClass.b = b;
        }

        public void PrintB()
        {
            Console.WriteLine(b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            myClass1.SetB(9);

            MyClass myClass2 = new MyClass();
            myClass2.PrintB();
        }
    }
}
