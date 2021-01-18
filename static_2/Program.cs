using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_2
{
    class MyClass
    {
        public MyClass()
        {
            counter++;
        }

        private static int counter;

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }

        public int ObjectsCount
        {
            get { return counter; }
        }

        public static int GetCounter()
        {
            return counter;
        }

        public int GetObjectsCount()
        {
            return counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            Console.WriteLine(myClass.ObjectsCount);

            MyClass myClass2 = new MyClass();

            Console.WriteLine(myClass.GetObjectsCount()); 

            MyClass myClass3 = new MyClass();

            Console.WriteLine(MyClass.Counter);

            Console.WriteLine(MyClass.GetCounter());
        }
    }
}
