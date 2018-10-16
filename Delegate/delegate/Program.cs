using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication1
{
    public delegate void TestDelegate(string message);
    class Foo
    {
        TestDelegate testDelegate;
        public void RegisterCallBack(TestDelegate testDelegate)
        {
            this.testDelegate = testDelegate;
        }
        public void TestIt()
        {
            testDelegate("hello back");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();
            foo.RegisterCallBack(TestDelegateMethod);
            foo.TestIt();
        }
        public static void TestDelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}