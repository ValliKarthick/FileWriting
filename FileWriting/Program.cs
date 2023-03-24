using System;
using System.IO;

namespace FileWriting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileOperation fileOperation = new FileOperation();
            //fileOperation.CreateFileUsingStreamWriter();
            //fileOperation.ReadFileUsingStreamReader();
            //fileOperation.PerformFileReadAllText();
            //fileOperation.PerformReadAllLines();
            fileOperation.CopyFile();

            //Console.Write("Enter Account No : ");
            //int accountNumber = Convert.ToInt32(Console.ReadLine()); 
            //Console.Write("Enter Account Holder Name : ");
            //string accountHolderName = Console.ReadLine();
            //Console.Write("Enter Bank Name : ");
            //string bankName = Console.ReadLine();
            //Console.Write("Enter Bank Balance : ");
            //int accountBalance = Convert.ToInt32(Console.ReadLine());

            //string fullPath = "C:/Users/vallinannu/source/repos/FileWriting/Output.csv";
            //string outPut = string.Format("{0},{1},{2},{3}\n",accountNumber.ToString(), accountHolderName, bankName, accountBalance.ToString());
            
            //File.WriteAllText(fullPath, outPut);

            //Console.WriteLine("Bank Informationwritten to file successfully.");
            //Console.WriteLine("The file output.csv should contain the bank information");
            //string readText = File.ReadAllText(fullPath);
            //Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}
