using System;
using System.Data;

namespace dotNetResearch
{
    class Base
    {
        public virtual void Test() { }
    }

    class Derived : Base
    {
        public override void Test() { }
    }

    public class Program
    {
        //static void Main(string[] args)
        //{
        //    Derived o = new Derived();
        //    o.Test();

        //    (o as Base).Test();

        //    Console.WriteLine("Press any key to exit...");
        //    Console.ReadKey(true);
        //    Environment.Exit(0);
        //}
    }
}
