using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CallBack_in_Thread
{
    public delegate void CallBackDelegateOfSum(int sum);
    class Program
    {
        public static void printsum(int sum)
        {
            Console.WriteLine("sum is " + sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Target number for Sum");
            int target =Convert.ToInt32(Console.ReadLine());

            CallBackDelegateOfSum callback = new CallBackDelegateOfSum(printsum);
            Number num = new Number(target, callback);

            Thread T1 = new Thread(new ThreadStart(num.FindSum));
            T1.Start();

        }
    }
    class Number
    {
        int _target;
        CallBackDelegateOfSum _callback;
        public Number(int target,CallBackDelegateOfSum callback)
        {
            this._target = target;
            this._callback = callback;

        }
        public void FindSum()
        {
            int sum = 0;
            for (int i = 0; i <= _target; i++)
            {
                sum = sum + i;
            }
            _callback(sum);
        }
    }
}
