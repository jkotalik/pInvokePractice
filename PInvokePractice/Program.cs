using System;

namespace PInvokePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var callback = new callback_struct(Hello);
            var res = PInvoke.callback_check(5, callback);
            Console.WriteLine(res);
        }
        static void Hello(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
