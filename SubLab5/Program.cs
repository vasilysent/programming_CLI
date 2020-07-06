using System;
using System.IO;

namespace SubLab5
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("path not specified");
                return;
            }
            String text;
            try
            {
                text = File.ReadAllText(args[0]);
            }
            catch (Exception exc)
            {
                Console.WriteLine("no such file in the directory");
                Console.ReadLine();
                return;
            }

            text = " " + text;
            String[] cuttedText;
            if (text.Contains("\""))
            {
                cuttedText = text.Split('"');
                for (int i = 0; i < (cuttedText.Length - 1) / 2; i++)
                {
                    if (cuttedText[2*i + 1].Length != 0)
                        Console.WriteLine(cuttedText[2 * i + 1]);
                }

            }

            Console.ReadLine();
        }
    }
}
