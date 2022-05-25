using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assingment3
{
    class Program
    {
        private static List<String> para = new List<string>();
        static void Main(string[] args)
        {
            String paragraph = @"file.txt";
            ReadFileInList(paragraph);
            printDetails();
            
        }

        private static void ReadFileInList(String file)
        {
            StreamReader st = File.OpenText(file);
           
            while (!st.EndOfStream)
            {
                String paraLine = st.ReadLine();
                para.Add(paraLine);
            }
        }

        private static int ContainsString(string line, string word)
        {
            
            var stringList = line.Split(" ");
            int occurence = 0;
            for(int i = 0; i < stringList.Length; i++)
            {
                if (stringList[i].Equals(word))
                {
                    occurence++;
                    
                }
            }
            return occurence;
        }
        private static void printDetails()
        {
            int occurence = 0;
            int index = 1;
            bool printed = false;
            foreach (var line in para)
            {
                //Console.WriteLine(line);
                occurence += ContainsString(line, "it");
                occurence += ContainsString(line, "It");

                if (occurence >= 2 && printed == false)
                {
                    Console.WriteLine("Line no is {0}", index);
                    printed = true;
                }

                index++;
            }

            Console.WriteLine("Total no of Occurence {0}",occurence);
        }
    }
}
