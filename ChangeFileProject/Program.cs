using System;
using System.IO;
using System.Text;

namespace ChangeFileProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bye.");
            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //process.EnableRaisingEvents = false;
            //process.StartInfo.FileName = @"C:\Users\j.gabele.4614\Desktop\test.txt";
            //process.Start();

            FileStream s = File.OpenWrite(@"C:\Users\j.gabele.4614\Desktop\test.txt");
            Byte[] info = (new UTF8Encoding(true).GetBytes("Das hier ist ein toller Text."));
            s.Write(info, 0, info.Length);
            s.Close();
            Console.ReadLine();
        }
    }
}

