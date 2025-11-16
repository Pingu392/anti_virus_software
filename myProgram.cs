using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Project1
{
    internal class myProgram
    {
        static void Main(String[] args) {
            DirectoryInfo directory = new DirectoryInfo("C:\\Users\\swive\\Documents\\C_Sharp_Dir");

            try
            {
                if (!directory.Exists)
                {
                    Console.Write("Directory does not exist!");
                    return;
                }

                String[] files = Directory.GetFiles(directory.FullName);
                foreach (var file in files) {
                    string hash = ComputeFileHash(file.ToString());
                    Console.WriteLine($"File: {file.ToString()}\nHash: {hash}\n");
                }


            }
            catch (Exception e) {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        static string ComputeFileHash(string filePath) {
            using (var sha256 = SHA256.Create()) {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hashBytes = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}
//238539696ebfd7845d0f0f56c06746396053f500029845d96e6476105709d2e5