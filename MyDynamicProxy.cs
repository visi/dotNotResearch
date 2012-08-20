using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Castle.Core;
using Castle.DynamicProxy;

namespace dotNetResearch {
    class MyDynamicProxy {

        public void Test() {
            ProxyGenerator generator = new ProxyGenerator();
            CallingLogInterceptor interceptor = new CallingLogInterceptor();
            SimpleSamepleEntity entity = generator.CreateClassProxy<SimpleSamepleEntity>(interceptor);
            entity.Name = "Richie";
            entity.Age = 50;
            Console.WriteLine("The entity is: " + entity);
            Console.WriteLine("Type of the entity: " + entity.GetType().FullName);
            Console.ReadKey();
        }
    }

    public class SimpleSamepleEntity {
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public override string ToString() {
            return string.Format("{{ Name: \"{0}\", Age: {1} }}", this.Name, this.Age);
        }
    }

    public class CallingLogInterceptor : IInterceptor {
        private int _indent = 0;
        private void PreProceed(IInvocation invocation) {
            if (this._indent > 0)
                Console.Write(" ".PadRight(this._indent * 4, ' '));
            this._indent++;
            Console.Write("Intercepting: " + invocation.Method.Name + "(");
            if (invocation.Arguments != null && invocation.Arguments.Length > 0)
                for (int i = 0; i < invocation.Arguments.Length; i++) {
                    if (i != 0) Console.Write(", ");
                    Console.Write(invocation.Arguments[i] == null
                        ? "null"
                        : invocation.Arguments[i].GetType() == typeof(string)
                           ? "\"" + invocation.Arguments[i].ToString() + "\""
                           : invocation.Arguments[i].ToString());
                }
            Console.WriteLine(")");
        }
        private void PostProceed(IInvocation invocation) {
            this._indent--;
        }
        public void Intercept(IInvocation invocation) {
            this.PreProceed(invocation);
            invocation.Proceed();
            this.PostProceed(invocation);
        }
    }
}
