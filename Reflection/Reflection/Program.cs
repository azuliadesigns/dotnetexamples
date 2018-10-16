using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // don't forget your using statements at the top of your code...


            // class declaration, and method declaration...

            // remember that this string is case-sensitive, so be careful
            Type t = Type.GetType("Foo"); //"System.String");

            // check to see if we have a valid value. If our object is null, the type does not exist...
            if (t == null)
            {
                // Don't assume that it is a SYSTEM datatype...
                Console.WriteLine("Ensure that you specify valid types.");
                Console.WriteLine("Case matters (Byte is not the same as byte).");
                return; // don't continue processing
            }

            // iterate through all the field members
            FieldInfo[] fi = t.GetFields(); // (BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (FieldInfo f in fi)
            {
                Console.WriteLine(f);
            }

            // iterate through all the method members
            MethodInfo[] mi = t.GetMethods(); // (BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (MethodInfo m in mi)
            {
                Console.WriteLine(m);
            }

            object [] arguments = {3, 4};
            object result;

            Console.WriteLine();

            // invoke a static method
            result = t.InvokeMember("method1", BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.Static, null, null, arguments);
            Console.WriteLine("result: {0}\n", result);

            // invoke an instance method
            Assembly asm = Assembly.GetExecutingAssembly();
            Object obj = asm.CreateInstance("Foo");
            result = t.InvokeMember("method2", BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.Instance, null, obj, arguments);

            Console.WriteLine("result: {0}\n", result);
        }
    }
}

public class Foo
{
    public static int method1(int x, int y)
    {
        Console.WriteLine("Foo.method1");
        return x + y;
    }

    public int method2(int x, int y)
    {
        Console.WriteLine("Foo.method2");
        return x * y;
    }
}