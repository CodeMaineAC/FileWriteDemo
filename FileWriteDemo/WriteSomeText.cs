using System;
using System.IO;

namespace FileWriteDemo
{
    class WriteSomeText
    {
        static void Main(string[] args)
        {
            FileStream outFile = new 
                FileStream("SomeText.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            Console.WriteLine("Text to write to file>> ");
            string text = Console.ReadLine();

            try
            {
                writer.WriteLine(text);
            }
            finally
            {
                writer.Close();
                outFile.Close();
            }
        }
    }
}
