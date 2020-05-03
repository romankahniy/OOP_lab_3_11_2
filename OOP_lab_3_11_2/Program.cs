using System;
using System.IO;

namespace OOP_lab_3_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть назву предмету (OOP/AP).");

            string name = Console.ReadLine();

            try
            {
                StreamReader fromFile = new StreamReader(name + ".txt");

                string str = fromFile.ReadToEnd();

                Console.WriteLine(str);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Введено неправильну назву предмету.");
            }
        }
    }
}
