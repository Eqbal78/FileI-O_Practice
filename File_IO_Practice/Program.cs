using System;

namespace File_IO_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************Welcome to File I/O Practices!*****************************");

            Console.WriteLine("\n++++++++++++++++ File is Exist or Not +++++++++++++++++++++++");
            FileReadAndWrite.FileExist();

            Console.WriteLine("\n+++++++++++++++++ Read All Line +++++++++++++++++++++");
            FileReadAndWrite.ReadAllLine();

            Console.WriteLine("\n+++++++++++++++++ Read All Text +++++++++++++++++++++");
            FileReadAndWrite.ReadAllText();

            Console.WriteLine("\n+++++++++++++++++ Write Lines +++++++++++++++++++++++");
            FileReadAndWrite.WriteAllLine("\n How Are you..!");

            Console.WriteLine("\n++++++++++++++++++ Copy File ++++++++++++++++++++++++");
            FileReadAndWrite.CopyFile();

            Console.WriteLine("\n++++++++++++++++++++ Deleting File ++++++++++++++++++++");
            FileReadAndWrite.DeleteFile(@"C:\Users\HP\Desktop\DotNet projects\File_IO_Practice\File_IO_Practice\PracticeCopy.txt");

            Console.WriteLine("\n++++++++++++++++++ Stream Read File ++++++++++++++++++++++++");
            StreamReadAndWrite.StreamReader();

            Console.WriteLine("\n++++++++++++++++++ Stream Write File ++++++++++++++++++++++++");
            StreamReadAndWrite.StreamWrite();
        }

    }
}
