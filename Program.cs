using System;
using System.IO;

namespace csPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("ebnf.txt"))
                {
                // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd().Replace(";\r\n",";;").Replace("\r\n","").Replace(";;",";\r\n");
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
