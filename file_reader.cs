using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace file_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter ofile ;
            ofile = new StreamWriter("test.txt");
            ofile.WriteLine("this is a message");
            ofile.WriteLine("Hello world!");

            ofile.Close();


            //read file
            StreamReader ifile;
            Console.WriteLine("this is the content of file test.txt: \n" );

            ifile = new StreamReader("test.txt");
            Console.WriteLine (ifile.ReadToEnd ());
            ifile.Close();
            Console.ReadKey();
            

        }
    }
}
