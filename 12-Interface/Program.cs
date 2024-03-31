using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDBContext dbContext = new MySQL();

            dbContext.insert();
            dbContext.update();
            dbContext.delete();
            dbContext.select();

            IFile fileInfo1 = new FileInfo();
            fileInfo1.ReadFile();
            fileInfo1.WriteFile("Escribiendo en el archivo 1...");

            FileInfo fileInfo2 = new FileInfo();
            fileInfo2.ReadFile();
            fileInfo2.WriteFile("Escribiendo en el archivo 2...");
            Console.WriteLine(fileInfo2.Name);
        }
    }
}
