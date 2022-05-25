using System;
using System.IO;

namespace Assingment4
{
    class Program
    {
        private static void WriteToFile(String fileName, int[] arr)
        {
            FileInfo inf = new FileInfo(fileName);
            StreamWriter wr = inf.CreateText();
            for (int i = 0; i < arr.Length; i++)
            {
                wr.WriteLine(arr[i]);
            }

            wr.Close();
        }

        private static void ReadFromFile(String fileName, int[] arr, int arrSize)
        {    
            FileInfo inf = new FileInfo(fileName);
            StreamReader re = inf.OpenText();

            int index = 0;
            while (!re.EndOfStream)
            {
                if(index == arrSize)
                {
                    Console.WriteLine("Please Increase the buffer size to read more data");
                    break;
                }
                arr[index] = Convert.ToInt32(re.ReadLine());
                index++;
            }
            re.Close();
        }
        static void Main(string[] args)
        {
            int arraySize;
            arraySize = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arraySize];

            for(int i = 0; i < arraySize; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] dataRead = new int[arraySize];
            String fileName = @"file.txt";
            WriteToFile(fileName, arr);
            ReadFromFile(fileName, dataRead, arraySize);

            Console.WriteLine();
            Console.WriteLine("Reading from file and Writing to Console: ");
            for(int i = 0; i < arraySize; i++)
            {

                Console.WriteLine(dataRead[i]);
            }
            
        }
    }
}
