using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PInvokePractice
{
    public delegate void callback_struct(int a, int b);

    public static class PInvoke
    {


        [DllImport("PInvokeDll.dll")]
        public static extern int callback_check(int a, callback_struct cs);


    }
}
