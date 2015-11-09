using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace directory_exp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter directory name");
            string dirname = Console.ReadLine();

            if (Directory.Exists(dirname) == false)
                Directory.CreateDirectory("c:/sample");
            else
                Console.WriteLine("Directory already exists");
        }
    }
}
