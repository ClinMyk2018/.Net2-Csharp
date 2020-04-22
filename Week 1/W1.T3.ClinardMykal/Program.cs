using System;

namespace W1.T3.ClinardMykal
{
    internal interface IOne 
    {
        void Hello();
    }

    internal interface ITwo 
    {
        void Hello();
    }

    internal class Test : IOne, ITwo 
    {
        void IOne.Hello()
        {
            Console.WriteLine("Hello to all-A");
        }

        void ITwo.Hello()
        {
            Console.WriteLine("Hello to all-B");
        }

        public void Hello()
        {
            Console.WriteLine("Hello inside of Test");
        }
    }

    public class interfacetest
    {
        public static void Main()
        {
            IOne Obj1 = new Test();
            Obj1.Hello();
            ITwo Obj2 = new Test();
            Obj2.Hello();
            Test Obj3 = new Test();
            Obj3.Hello();
        }
    }
}