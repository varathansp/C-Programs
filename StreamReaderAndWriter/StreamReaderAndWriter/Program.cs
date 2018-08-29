using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamReaderAndWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Sample Files\Log.txt");
            Console.Write(reader.ReadToEnd());
            reader.Close();

            StreamWriter writer = new StreamWriter(@"C:\Sample Files\Log.txt");
            writer.Write("This is written by StreamWriter");
            writer.Close();
        
        }
    }
}
