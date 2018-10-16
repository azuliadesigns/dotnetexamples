using System;
using System.Collections.Generic;
using System.Text;

interface IFoo
{
    void method1();
    void method2(string str);
    void method3(int i);
}

class FooBase
{
    public void method1()
    {
        Console.WriteLine("FooBase.method1()");
    }
}

class FooA : FooBase, IFoo
{
    public void method2(string str)
    {
        Console.WriteLine("FooA.method2()");
    }
    public void method3(int i)
    {
        Console.WriteLine("FooA.method3()");
    }
}

class FooB : FooBase, IFoo
{
    public void method2(string str)
    {
        Console.WriteLine("FooB.method2()");
    }
    public void method3(int i)
    {
        Console.WriteLine("FooB.method3()");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFoo fa = new FooA();
        fa.method1();
        fa.method2("hi");
        fa.method3(3);

        IFoo fb = new FooB();
        fb.method1();
        fb.method2("hi");
        fb.method3(3);
    }
}

