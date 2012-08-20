using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotNetResearch {
    public class NumberList {
        // Create an array of integers.
        public static int[] ints = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };

        // Define a property that returns only the even numbers.(偶数)
        public static IEnumerable<int> GetEven() {
            // Use yield to return the even numbers in the list.
            foreach (int i in ints)
                if (i % 2 == 0)
                    yield return i;
        }

        //static void Main(string[] args) {

        //    // Display the even numbers.
        //    //Console.WriteLine("Even numbers");
        //    //foreach (int i in NumberList.GetEven())
        //    //    Console.WriteLine(i);

        //    //Type t = typeof(NumberList);

        //    //t.GetProperties().Select(x => x.GetAccessors(false).Length == 0);
        //}

    }
}
