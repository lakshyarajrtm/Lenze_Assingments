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
            try
            {
                Console.WriteLine("Please enter the array size");
                arraySize = Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }
            int[] arr = new int[arraySize];
            Console.WriteLine("Please enter the number to be stored: ");
            for (int i = 0; i < arraySize; i++)
            {
                try
                {
                    

                    arr[i] = Convert.ToInt32(Console.ReadLine());

                }
                catch(Exception e)
                {
                    Console.WriteLine("please enter a valid number");
                    return;
                }
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

            int findPairOf;
            Console.WriteLine("Input number to find pair");
            try
            {

                findPairOf = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception _)
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }

            int count = 0;
            for (int i = 0; i < arraySize; i++)
            {
                if (dataRead[i] == findPairOf)
                {
                    count++;
                }


            }

            if (count > 0)
                Console.WriteLine("Number of pairs {0}", count % 2);
            else
                Console.WriteLine("Number not found in array");
        }
    }
}
