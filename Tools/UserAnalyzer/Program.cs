using System;
using System.Security.Principal;

namespace UserAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            Console.WriteLine("Is admin?:? {0}", principal.IsInRole(WindowsBuiltInRole.Administrator));
        }
    }
}
