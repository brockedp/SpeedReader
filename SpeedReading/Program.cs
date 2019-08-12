using System;
using System.IO;

namespace SpeedReading
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            string[] pathSubstring = path.Split('\\');
            int binIndex = Array.IndexOf(pathSubstring, "bin");
            binIndex--;
            string filePath = "";
            for (int i = 0; i <= binIndex; i++)
            {
                filePath += pathSubstring[i] + "\\";
            }

            string textFile = "TextFile1.txt";
            filePath = filePath + textFile;

            Console.WriteLine("Welcome to Speed Reading!");
            Console.WriteLine();
            int words = Validator.GetIntWithinRange("Please enter how many words at a time you want to read(1-6): ", 1, 6);
            double time = Validator.GetDoubleWithinRange("Please enter how quickly you want the words to scan:(.25-2) ", .25, 2);
            int milliTime = (int)(time * 1000);
            Console.Clear();

            ReadFileChoice(filePath, words, milliTime);

        }
        
        public static void ReadFile(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string line = reader.ReadLine();
            while (line != null)
            {
                if (line == "")
                {
                    line = reader.ReadLine();
                }
                else
                {
                    string[] items = line.Split(' ');
                    foreach (var item in items)
                    {
                        Console.WriteLine(item);
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();
                    }
                    line = reader.ReadLine();
                }
            }
        }
        public static void ReadFile2Word(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string line = reader.ReadLine();
            while (line != null)
            {
                if (line == "")
                {
                    line = reader.ReadLine();
                }
                else
                {
                    string[] items = line.Split(' ');
                    for(int i = 0; i< items.Length-1;i+=2)
                    {
                        Console.WriteLine($"{items[i]} {items[i+1]}");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();
                    }
                    line = reader.ReadLine();
                }
            }
        }
        public static void ReadFileChoice(string filePath, int count, int time)
        {
            StreamReader reader = new StreamReader(filePath);
            string line = reader.ReadLine();
            while (line != null)
            {
                if (line == "")
                {
                    line = reader.ReadLine();
                }
                else
                {
                    string[] items = line.Split(' ');
                    for (int i = 0; i < items.Length -(count-1); i += count)
                    {
                        for (int j = 0; j < count; j++)
                        {
                            //Console.WriteLine();
                            Console.Write($"{items[i+j]} ");

                        }
                        System.Threading.Thread.Sleep(time);
                        Console.Clear();
                    }
                    line = reader.ReadLine();
                }
            }
        }

    }
}
