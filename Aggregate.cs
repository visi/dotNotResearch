using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace GiftGis {
    class Linq_Aggregate_Test_Class {
        //static void Main(string[] args) {
        //    long x = 12345L;
        //    long bBB = 12345;
        //    if (x == bBB) { Console.Write("YES"); }
        //    String newline = Environment.NewLine;
        //    Double[] nums = new Double[] { 2, 4, 6, 8 };
        //    var strs = String.Join(",", (nums.Select<Double, String>(v => v.ToString())).ToArray());
        //    Console.ForegroundColor = ConsoleColor.Magenta;
        //    Console.WriteLine("Double数组：" + strs);
        //    Console.WriteLine("应用Aggregate方法，不同的参数形式下不同的结果");
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine(newline + "a+b=" + nums.Aggregate((a, b) => a + b).ToString());
        //    Console.WriteLine("计算过程：2->2+4->6+6->12+8=20");
        //    Console.WriteLine(newline + "a/2+b=" + nums.Aggregate((a, b) => a / 2 + b).ToString());
        //    Console.WriteLine("计算过程：2/2->1->1+4->2.5+6->4.25+8=12.25");
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine(newline + "14, (a, b) => a / 2 + b=" +
        //        nums.Aggregate(14.0, (a, b) => a / 2 + b).ToString());
        //    Console.WriteLine("计算过程：14/2+2>9/2 +4=8.5/2 +6>10.25/2+8 >13.125" + newline + "相当于数组前面加上了一元素：14");
        //    Console.WriteLine(newline + "a+b/2=" + nums.Aggregate((a, b) => a + b / 2).ToString());
        //    Console.WriteLine("2->2+4/2->4+6/2->7+8/2=11");
        //    Console.WriteLine(newline + "a*b=" + nums.Aggregate((a, b) => a * b).ToString());
        //    Console.WriteLine("计算过程:2->2*4->8*6->48*8=438");
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine(newline + "下在MSDN网上的一个例子，\n这个例子是用户银行卡上有100RMB，" +
        //        "现在他尝试取消，\n每次取款的数是一个数组，\n注意了：\n如果他尝试取款的数大于当前用户账号的余额，" +
        //        "\n则是取不了款的，\n现在要求得用户最终账号的余额是多少");
        //    /*This sample uses Aggregate to create a 
        //     * running account balance that subtracts each withdrawal
        //     * from the initial balance of 100,
        //     * as long as the balance never drops below 0*/
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    double startBalance = 100.0;
        //    int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };
        //    Console.WriteLine(newline + "最初存款：{0}\n每次尝试取款的数目：{1}",
        //        startBalance, String.Join(",", attemptedWithdrawals.Select<Int32, String>(v => v.ToString())));
        //    Console.WriteLine(newline + "函数书写方式:\n" +
        //    "\ndouble endBalance =" +
        //    "\n    attemptedWithdrawals.Aggregate(startBalance," +
        //    "\n(balance, nextWithdrawal) =>" +
        //    "\n((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));");
        //    double endBalance =
        //        attemptedWithdrawals.Aggregate(startBalance,
        //            (balance, nextWithdrawal) =>
        //                ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));
        //    // endBalance= 20
        //    Console.WriteLine("Ending balance(最终余额): {0}", endBalance);
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine(newline +
        //        "执行过程的人工分析\n" +
        //    "\n第1次取20RMB，剩余：80RMB" +
        //    "\n第2次取10RMB，剩余：70RMB" +
        //    "\n第3次取40RMB，剩余：30RMB" +
        //    "\n第4次取50RMB，无法取得，剩余30RMB" +
        //    "\n第5次取10RMB，剩余 20RMB" +
        //    "\n第6次取70RMB，取不了，剩余20RMB" +
        //    "\n第7次取30RMB，取不了，剩余20RMB" +
        //    "\n所以最后的结果是 20RMB");


        //    string[] names1 = { "Hartono, Tommy" };
        //    string[] names2 = { "Adams, Terry", "Andersen, Henriette Thaulow",
        //                       "Hedlund, Magnus", "Ito, Shu" };
        //    string[] names3 = { "Solanki, Ajay", "Hoeing, Helge",
        //                       "Andersen, Henriette Thaulow",
        //                       "Potra, Cristina", "Iallo, Lucio" };

        //    List<string[]> namesList =
        //        new List<string[]> { names1, names2, names3 };

        //    // Only include arrays that have four or more elements
        //    IEnumerable<string> allNames =
        //        namesList.Aggregate(Enumerable.Empty<string>(),
        //        (current, next) => next.Length > 3 ? current.Union(next) : current);

        //    foreach (string name in allNames) {
        //        Console.Write( name + "\n");
        //    }

        //    Console.ResetColor();


        //}
    }
}