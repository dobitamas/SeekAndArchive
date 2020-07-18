using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SeekAndArchive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please provide the name of the file below which you are searching for");
            FileInfo fileInfo = new FileInfo(Console.ReadLine() ?? throw new InvalidOperationException("The file name can't be blank!"));
            Console.WriteLine("And now please provide the path of the directory where to search below!");
            DirectoryInfo directoryInfo = new DirectoryInfo(Console.ReadLine() ?? throw new InvalidOperationException("The path of the directory can't be blank!"));
        }

        public string[] Search(FileInfo fileInfo, DirectoryInfo directoryInfo)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
