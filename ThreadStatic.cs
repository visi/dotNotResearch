using System.Threading;
namespace dotNetResearch
{
    /// <summary>
    /// 默认情况下，一个静态字段被进程中所有线程共享
    /// 对静态字体应用System.ThreadStatic，强迫CLR为进程中的每个线程创建该静态字段的实例
    /// </summary>
    class ThreadStatic
    {
        [System.ThreadStatic]
        static string str = "InitValue";

        static void DisplayStr()
        {
            System.Console.WriteLine("Thread{0}: {1}",
                Thread.CurrentThread.ManagedThreadId,str);
        }

        static void ThreadProc()
        {
            DisplayStr();
            str = "ThreadProc Value";
            DisplayStr();
        }

        //static void Main(string[] args)
        //{
        //    DisplayStr();
        //    Thread r = new Thread(ThreadProc);
        //    r.Start();
        //    r.Join();
        //    DisplayStr();
        //}
    }
}
/*********************
 * 不使用System.ThreadStatic属性，则输出：
 * Thread1: InitValue
 * Thread3: InitValue
 * Thread3: ThreadProc Value
 * Thread1: ThreadProc Value
 * 
 * 使用System.ThreadStatic属性，则输出：
 * Thread1: InitValue
 * Thread3: 
 * Thread3: ThreadProc Value
 * Thread1: InitValue
 * ******************/
