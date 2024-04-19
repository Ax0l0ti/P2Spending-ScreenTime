
using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        ProcessStartInfo start = new ProcessStartInfo();

        start.FileName = "/Users/ajeyanthananthajeyasri/PycharmProjects/pythonProject3/venv/bin/python3";
        start.Arguments = $"\"{"/Users/ajeyanthananthajeyasri/PycharmProjects/pythonProject3/main.py"}"; // Pass arguments
        start.UseShellExecute = false;
        start.RedirectStandardOutput = true;
        start.WorkingDirectory = "/Users/ajeyanthananthajeyasri/PycharmProjects/pythonProject3";
        // Explicitly set the working directory to the directory of the C# executable
        //Console.WriteLine("C# working directory: " + start.WorkingDirectory);
        //start.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
        //Console.WriteLine(start.WorkingDirectory);


        using (Process process = Process.Start(start))
        {
            using (StreamReader reader = process.StandardOutput)
            {
                string result = reader.ReadToEnd();
                Console.WriteLine("Result from Python: " + result);
            }
        }
    }
}
