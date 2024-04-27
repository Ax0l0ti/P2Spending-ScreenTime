
using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        ProcessStartInfo start = new ProcessStartInfo();
        string scriptPath = "/Users/ajeyanthananthajeyasri/PycharmProjects/pythonProject3/test.py";
        string category = "Overall";  


        start.FileName = "/Users/ajeyanthananthajeyasri/PycharmProjects/pythonProject3/venv/bin/python3";
        start.Arguments = $"\"{scriptPath}\" {category}";  
        start.UseShellExecute = false;
        start.RedirectStandardOutput = true;
        // Explicitly set the working directory to the directory of the C# executable
        //Console.WriteLine("C# working directory: " + start.WorkingDirectory);
        start.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
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
