using System;
using System.Diagnostics;

namespace ProcessAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var process in Process.GetProcesses())
            {
                Console.WriteLine("Process ID: {0}  \tProcess Name: {1}  \t", process.Id, process.ProcessName);
            }
            // https://ourcodeworld.com/articles/read/439/how-to-list-all-windows-processes-and-their-attributes-task-manager-like-with-c-in-winforms
            //need to filter by system, then dump what it is, how long its ran, where it runs from etc
        }
    }

}