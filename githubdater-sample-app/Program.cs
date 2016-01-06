using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubdater.SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GitHubdater Sample App - v0.1 (remember this version *wink*)");
            Console.WriteLine("Press any key to update...");

            Console.ReadLine();

            int pid = Process.GetCurrentProcess().Id;
            string pidArgument = "-p=" + pid;

            string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string followUpPathArgument = "-f=" + assemblyName + ".exe";

            Process.Start("githubdater-app.exe", pidArgument + " " + followUpPathArgument);
        }
    }
}
