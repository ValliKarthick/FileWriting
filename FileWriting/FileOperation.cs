using System;
using System.IO;

namespace FileWriting
{
    public class FileOperation
    {
        string filePath = @"C:\Users\vallinannu\source\repos\FileWriting\Testfile.txt";
        string copyPath = @"C:\Users\vallinannu\source\repos\FileWriting\MyCopyFile.txt";
        public void CreateFileUsingStreamWriter()
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter streamWriter = File.CreateText(filePath))
                {
                    streamWriter.WriteLine("Third Run..");
                    streamWriter.WriteLine("Wait..");
                    streamWriter.WriteLine("Third Run..");
                    streamWriter.WriteLine("Wait..");
                }
            }
        }
        public void ReadFileUsingStreamReader()
        {
            using (StreamReader streamReader = File.OpenText(filePath))
            {
                string fileContents;
                while ((fileContents = streamReader.ReadLine()) == "Process Completed")
                {
                    Console.WriteLine(fileContents);
                }
            }
        }
        public void PerformFileReadAllText()
        {
            //string writeText = "Hello World!";
            //File.WriteAllText(filePath, writeText);

            string readText = File.ReadAllText(filePath);
            Console.WriteLine(readText);
        }
        public void PerformReadAllLines()
        {
            String[] output = File.ReadAllLines(filePath);

            Console.WriteLine(output[0]);
            Console.WriteLine(output[1]);
        }
        public void CopyFile()
        {
            string sourcePath = filePath;

            string destinationPath = copyPath;

            //File.Copy(filePath, copyPath);

            if (File.Equals(filePath, copyPath))
            {
                Console.WriteLine("Yes..");
            }
            else Console.WriteLine("No..");
        }
    }
}
