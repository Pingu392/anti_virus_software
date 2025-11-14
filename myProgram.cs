using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Project1
{
    internal class myProgram
    {
        static void Main(String[] args) {
            String root = @"C:\Users\swive\Documents\C_Sharp_Dir";
            String subroot = @"C:\Users\swive\Documents\C_Sharp_Dir\subDir";

            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
                Console.Write("Directory created!");
            }

            Directory.Delete(root, true);
        }
    }
}
