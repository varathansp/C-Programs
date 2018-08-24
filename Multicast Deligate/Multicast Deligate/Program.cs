using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multicast_Deligate
{
    public delegate void PrintDelegate();
    public delegate int NumberDelegate();
    public delegate void OutPutParameterDelegate(out int result);
    class Program
    {
        static void Main(string[] args)
        {
            //PrintDelegate printDelegate1, printDelegate2, printDelegate3, printDelegate4;
            //printDelegate1 = new PrintDelegate(PrintMethod1);
            //printDelegate2 = new PrintDelegate(PrintMethod2);
            //printDelegate3 = new PrintDelegate(PrintMethod3);

            //printDelegate4 = printDelegate1 + printDelegate2 + printDelegate3;
            //printDelegate4();

            //NumberDelegate();
            NumberDelegate numberDelegate = new NumberDelegate(NumberMethod1);
            numberDelegate += NumberMethod2;

            int result=numberDelegate();

            Console.WriteLine(result);


            //void OutPutParameterDelegate(out int result)

            OutPutParameterDelegate outPutParameterDelegate = new OutPutParameterDelegate(OutMethod1);
            outPutParameterDelegate += OutMethod2;
            int FinalResult =5;
            outPutParameterDelegate(out FinalResult);

            Console.WriteLine(FinalResult);


        }
        public static void PrintMethod1()
        {
            Console.WriteLine("First method printed");
        }
        public static void PrintMethod2()
        {
            Console.WriteLine("Second method printed");
        }
        public static void PrintMethod3()
        {
            Console.WriteLine("Third method printed");
        }
        public static int NumberMethod1()
        {
            return 1;
        }
        public static int NumberMethod2()
        {
            return 2;
        }
        public static void OutMethod1(out int res)
        {
            res = 1;
        }
        public static void OutMethod2(out int res)
        {
            res = 2;
        }
    }
}
