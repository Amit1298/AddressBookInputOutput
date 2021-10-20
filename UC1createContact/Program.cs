using System;
using System.IO;

namespace UC1createContact
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"L:\BridgeLabz Solution\Dot net\September\New Batch\Oct\18-10-2021\Addressbook IO\UC1createContact\Addressbook.txt";    //@ is verbatim literal
            if(File.Exists(path))
            {
                Console.WriteLine("File is Presnt");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("File is not Presnt");
            }
        }
    }
}
