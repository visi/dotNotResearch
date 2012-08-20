
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ThrowEx
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    ThrowSample ts = new ThrowSample();
        //    try
        //    { ts.ThrowExMethod(); }
        //    catch (Exception ex)
        //    { Console.WriteLine(ex.ToString()); }
        //    Console.WriteLine("----------------------------------------------------------");
        //    try
        //    { ts.ThrowExMethod2(); }
        //    catch (Exception ex)
        //    { Console.WriteLine(ex.ToString()); }
        //    Console.ReadKey();
        //}
    }
    class ThrowSample
    {
        private void ExceptionMethod() { throw new DivideByZeroException(); }
        public void ThrowExMethod()
        {
            try
            { this.ExceptionMethod(); }
            catch (Exception ex)
            { throw; }
        }
        public void ThrowExMethod2()
        {
            try
            { this.ExceptionMethod(); }
            catch (Exception ex)
            { throw ex; }
        }
    }
}