using System;
using _12_Interface;

namespace _12_Interface
{
    public interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }
}

class FileInfo : IFile
{

    public string Name = "File.txt";

    public void ReadFile()
    {
        Console.WriteLine("Reading File");
    }

    public void WriteFile(string text)
    {
        Console.WriteLine(text);
    }
}