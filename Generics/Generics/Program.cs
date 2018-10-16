using System;
using System.Collections.Generic;

class Generics
{
    static void Main(string[] args)
    {
        // create arrays of various types
        int[] intArray = { 1, 2, 3, 4, 5, 6 };
        double[] doubleArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
        char[] charArray = { 'A', 'B', 'C', 'D', 'E' };

        DisplayArray(intArray);
        DisplayArray(doubleArray);
        DisplayArray(charArray);

        Console.ReadLine();

        MyGeneric<int> mygenericint = new MyGeneric<int>();
        mygenericint.GenericField = 13;
        mygenericint.GenericMethod(42);

        MyGeneric<string> mygenericstring = new MyGeneric<string>();
        mygenericstring.GenericField = "xxx";
        mygenericstring.GenericMethod("xxx");

        MyGeneric<int> mygenericstring2 = new MyGeneric<int>();
        mygenericstring2.GenericField = "xxx";
        mygenericstring2.GenericMethod("xxx");
    }

    // generic method displays array of any type
    static void DisplayArray<E>(E[] array)
    {
        Console.WriteLine("Display array of type " + array.GetType() + ":");
        foreach (E element in array)
            Console.Write(element + " ");

        Console.WriteLine();
    }
}

public class MyGeneric<T>
{
    public T GenericField;
    public void GenericMethod(T t)
    {
        Console.WriteLine("GenericMethod parameter type: " + t.GetType());
    }
}

