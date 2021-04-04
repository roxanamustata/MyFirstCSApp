using System;
using System.IO;

namespace ReadWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file path:");
            string path = Console.ReadLine();


            //Write in file the lines read from the console
            try
            {
                //add parameter true if for appending to file, without overwriting
                var writer = new StreamWriter(path, true);
                string line;

                while ((line = Console.ReadLine()) != "exit")
                {
                    writer.WriteLine(line);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }


            // Read lines from file and show them on console
            try
            {
                var reader = new StreamReader(path);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                reader.Close();

            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

    }
}

