//Console to administratively restart multiple PCs
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace PC_Restart_Tool
{
    class Program
    {
        public static void Main()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("shutdown -i");
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();
        }

    }
}
