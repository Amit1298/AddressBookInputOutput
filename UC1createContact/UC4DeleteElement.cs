using System;
using System.IO;

namespace UC4DeleteElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"L:\BridgeLabz Solution\Dot net\September\New Batch\Oct\18-10-2021\Addressbook IO\UC4DeleteElement\Addressbook.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File is Present");
                deleteFile();
            }
            else
            {
                Console.WriteLine("File is not Present");
            }
        }
        public static void deleteFile()
        {
            string path1 = @"L:\BridgeLabz Solution\Dot net\September\New Batch\Oct\18-10-2021\Addressbook IO\UC4DeleteElement\Addressbook1.txt";
            File.Delete(path1);
            Console.WriteLine("Person Delete successfully");
        }
    }
}
