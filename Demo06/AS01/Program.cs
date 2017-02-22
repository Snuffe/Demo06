using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS01
{
    class Program
    {
        static void Main(string[] args)
        {
            string userData = "\n";
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"C:\Users\Käyttäjä\Source\Repos\Demo6_01\text.txt");
            while (userData != "")
            {
                Console.Write("Give a text line (enter ends) : ");
                userData = Console.ReadLine();
                if (userData != "")
                {
                    outputFile.WriteLine(userData);
                }
            }
            outputFile.Close();

            var lines = File.ReadAllLines(@"C:\Users\Käyttäjä\Source\Repos\Demo6_01\text.txt");
            Console.WriteLine("Contents of text.txt: ");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            outputFile.Close();
        }
    }
}
