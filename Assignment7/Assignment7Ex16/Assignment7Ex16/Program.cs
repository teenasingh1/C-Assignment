using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7Ex16
{
    public class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\teenasingh\Downloads");
            Console.WriteLine("\n\n Directory:: {0}", dir.FullName);
            FileInfo[] textFileInfo = dir.GetFiles("*.txt");
            FileInfo[] allFileInfo = dir.GetFiles();
            Console.WriteLine("\n\n --- Number of text files ---");
            Console.WriteLine(" no of text files:: {0}", textFileInfo.Length);
            var groupFilesByExtension =
              from file in allFileInfo
              group file by file.Extension into ext
              select ext;
            var allFilesBySize =
              from file in allFileInfo
              orderby file.Length descending
              select file;
            Console.WriteLine("\n\n --- Number of files per extension type ---");
            foreach (var item in groupFilesByExtension)
            {
                Console.WriteLine(" Extension:: '{0}' Files:: {1}", item.First().Extension, item.Count());
            }
            Console.WriteLine("\n\n --- The top 5 largest files ---");
            byte i = 0;
            foreach (var item in allFilesBySize)
            {
                Console.WriteLine(" File:: '{0}' Size:: {1} Bytes", item.Name, item.Length);
                i++;
                if (i == 5)
                    break;
            }
            var largestFile = allFilesBySize.ToArray()[0];
            Console.WriteLine("\n\n --- File with maximum length ---");
            Console.WriteLine(" File:: '{0}' Length:: {1}", largestFile.Name, largestFile.Length);
        }
        
    }
}
