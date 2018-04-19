using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a string to write to the file");
            string suppliedInfo = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter("programInfo.txt", true))
            {
                writer.WriteLine(suppliedInfo);
                writer.Close();
            }

            string file = string.Empty;
            using (StreamReader reader = new StreamReader("programInfo.txt"))
            {
                file = reader.ReadToEnd();
            }
            Console.WriteLine(file);

                Console.ReadKey();

        }
    }
}
