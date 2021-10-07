using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO_Practice
{
    public class FileReadAndWrite
    {
        public static string path = @"C:\Users\HP\Desktop\DotNet projects\File_IO_Practice\File_IO_Practice\Practice.txt";
     
        public static void FileExist()
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Given Text file is exist\n");
            }
            else
            {
                Console.WriteLine("File is Not Exist");
            }
        }

        public static void ReadAllText()
        {
            string str;
            str = File.ReadAllText(path);
            Console.WriteLine("\n=============================================");
            Console.WriteLine(str);
        }


        public static void ReadAllLine()
        {
            string[] lines;
            lines = File.ReadAllLines(path);
            //Console.WriteLine(lines[0]);
            //Console.WriteLine(lines[1]);
            Console.WriteLine("================================================\n");
            foreach (string str in lines)
            {
                Console.WriteLine(str);
            }
            
        }

        public static void WriteAllLine(string data)
        {
            File.AppendAllText(path, data);
            Console.WriteLine("\nString is Added");
             
        }

        public static void CopyFile()
        {
            string copyPath = @"C:\Users\HP\Desktop\DotNet projects\File_IO_Practice\File_IO_Practice\PracticeCopy.txt";
            File.Copy(path, copyPath);
            string str; 
            str = File.ReadAllText(copyPath);
            Console.WriteLine("\nfile is copy:-");
            Console.WriteLine(str);
            Console.WriteLine("Before delete CopyFile, the path is:-\n" + copyPath);
            DeleteFile(copyPath);

        }

        public static void DeleteFile(string copyPath)
        {
            File.Delete(copyPath);
            Console.WriteLine("\nFile is deleted successfully");
            Console.WriteLine("\nAfter delete CopyFile, the path is:-\n" + copyPath);
        }

    }
}
