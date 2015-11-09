using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace DirectoryListing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter directory name");
            string dirname = Console.ReadLine();
            if (Directory.Exists(dirname))
            {
                DirectoryInfo d = new DirectoryInfo(dirname);
                FileInfo[] f = d.GetFiles();
                for (int i = 0; i < f.Length; i++)
                {
                    Console.WriteLine("{0} ({1}),{2}", f[i].Name, f[i].Length, f[i].CreationTime.ToString());

                }
                long s = 0;
                for (int i = 0; i < f.Length; i++)
                {
                    s = s + f[i].Length;
                }
                double mb = s/(1024*1014);
                Console.WriteLine("Directory size in bytes : {0:f2} Mb", mb);
            }
            else
            {
                Console.WriteLine("DIRECTORY NOT FOUND");
            }
        }
    }
}
