using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotNetResearch {

    /// <summary>
    /// Not thread-safe
    /// 
    /// </summary>
    public sealed class SingletonA {
        static SingletonA instance = null;
        SingletonA() {
        }
        public static SingletonA Instance {
            get {
                if (instance == null) {
                    instance = new SingletonA();
                }
                return instance;
            }
        }
    }



    /// <summary>
    /// Simple thread-safety
    /// </summary>
    public sealed class SingletonB {
        static SingletonB instance = null;
        static readonly object padlock = new object();
        SingletonB() {
        }
        public static SingletonB Instance {
            get {
                lock (padlock) {
                    if (instance == null) {
                        instance = new SingletonB();
                    }
                    return instance;
                }
            }
        }
    }

    public sealed class Singleton3 {
        static Singleton3 instance = null;
        static readonly object padlock = new object();

        Singleton3() {
        }

        public static Singleton3 Instance {
            get {
                if (instance == null) {
                    lock (padlock) {
                        if (instance == null) {
                            instance = new Singleton3();
                        }
                    }
                }
                return instance;
            }
        }
    }

    public sealed class Singleton4 {
        static readonly Singleton4 instance = new Singleton4();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton4() {
        }

        Singleton4() {
        }

        public static Singleton4 Instance {
            get {
                return instance;
            }
        }
    }

    public sealed class Singleton5 {
        Singleton5() {
        }

        public static Singleton5 Instance {
            get {
                return Nested.instance;
            }
        }

        class Nested {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested() {
            }

            internal static readonly Singleton5 instance = new Singleton5();
        }
    }

    public class Bus {
        // Static constructor:
        static Bus() {
            System.Console.WriteLine("The static constructor invoked.");
        }
        public static void Drive() {
            System.Console.WriteLine("The Drive method invoked.");
        }
    }
    //class TestBus {
    //    static void Main() {
    //        Bus.Drive();
    //    }
    //}
}

