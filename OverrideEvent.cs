using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotNetResearch {
    public class OverrideEvent {
        //static void Main() {
        //    BaseClass bc = new BaseClass();
            
        //    bc.someEvent += new BaseClass.SomeEventHandle(bc_someEvent);
        //    bc.Run();
        
        //}

        static void bc_someEvent(object sender, EventArgs args) {
            Console.Write("you input a");
        }
    }

    public class BaseClass {
        public delegate void SomeEventHandle(object sender, EventArgs args);

        public event SomeEventHandle someEvent;

        public void Run ()
        {
            while (true) {
                if (Console.ReadLine() == "A") {
                    someEvent(null, new EventArgs());
                }
            }
        }

    }

    public class SubClass : BaseClass { 
       
    }

}
