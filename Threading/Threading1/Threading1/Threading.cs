using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

class Threading
{
    static Random rand = new Random();
    static DataObject dataobject = new DataObject();

    static void Main(string[] args)
    {
        ThreadStart threadstart = new ThreadStart(ThreadMethod);
        Thread thread = new Thread(threadstart);
        thread.Start();

        while (true)
        {
            lock (dataobject)
            {
                dataobject.x = rand.Next(0, 10);
                Thread.Sleep(rand.Next(10, 100));
                dataobject.y = rand.Next(0, 10);
                dataobject.sum = dataobject.x + dataobject.y;
                Thread.Sleep(rand.Next(10, 100));
                if (dataobject.sum != dataobject.x + dataobject.y)
                {
                    Console.WriteLine("COLLISION!");
                }
            }
            Thread.Sleep(rand.Next(10, 100));
        }
    }
    static void ThreadMethod()
    {
        while (true)
        {
            lock (dataobject)
            {
                dataobject.x = rand.Next(0, 10);
                Thread.Sleep(rand.Next(10, 100));
                dataobject.y = rand.Next(0, 10);
                dataobject.sum = dataobject.x + dataobject.y;
                Thread.Sleep(rand.Next(10, 100));
                if (dataobject.sum != dataobject.x + dataobject.y)
                {
                    Console.WriteLine("COLLISION!");
                }
            }
            Thread.Sleep(rand.Next(10, 100));

        }
    }
}

class DataObject
{
    public int x = 0;
    public int y = 0;
    public int sum = 0;
}

