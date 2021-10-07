using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO_Practice
{
    public class StreamReadAndWrite
    {
        public static string path = @"C:\Users\HP\Desktop\DotNet projects\File_IO_Practice\File_IO_Practice\Practice.txt";
        public static void StreamReader()
        {

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void StreamWrite()
        {
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("\nHi this is a newly line appended in file");
                sr.Close();
                //Console.WriteLine(File.ReadAllLines(path));
                StreamReader();
            }
        }
    }
}
