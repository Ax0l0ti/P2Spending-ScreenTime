


using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        ProcessStartInfo start = new ProcessStartInfo();

        start.FileName = "/Users/ajeyanthananthajeyasri/PycharmProjects/pythonProject3/venv/bin/python3";
        start.Arguments = $"\"{"/Users/ajeyanthananthajeyasri/PycharmProjects/pythonProject3/Main.py"}"; // Pass arguments
        start.UseShellExecute = false;
        start.RedirectStandardOutput = true;

        // Explicitly set the working directory to the directory of the C# executable
        start.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
        Console.WriteLine(start.WorkingDirectory);

        //Console.WriteLine("C# working directory: " + start.WorkingDirectory);

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
