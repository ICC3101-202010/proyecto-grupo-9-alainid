using System;
using System.Threading;

namespace Proyecto
{
    class Program
    {
        static void Main()
        {
            Input_Output ip = new Input_Output();
            ALAINID al = new ALAINID(ip);
            al.Operar();
            Thread.Sleep(1000);
        }
    }
}
