using OLCLibrary;
using System.Runtime.InteropServices;

namespace net6
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(RuntimeInformation.FrameworkDescription);
            await Library.MakeHttpCall();
        }
    }
}