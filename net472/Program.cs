using OLCLibrary;
using System.Runtime.InteropServices;
using System;
using System.Threading.Tasks;

namespace net472
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(RuntimeInformation.FrameworkDescription);
            await Library.MakeHttpCall();
            await Task.Delay(10000);
        }
    }
}
