using System;
using System.Collections.Generic;
using System.IO;

namespace UC2AddContact
{
    class Program
    {
        static void Main(string[] args)
        {
            AddContact();
            Console.WriteLine("------------------------------------------------");
            string path = @"L:\BridgeLabz Solution\Dot net\September\New Batch\Oct\18-10-2021\Addressbook IO\UC2AddContact\Addressbook.txt";
            string data = File.ReadAllText(path);
            Console.WriteLine(data);
        }
        public static void AddContact()
        {
            Dictionary<string, string> Contact = new Dictionary<string, string>();
            Contact.Add("FirstName", "Amit");
            Contact.Add("LastName", "Kumar");
            Contact.Add("Address", "DefenceColony");
            Contact.Add("City", "Agra");
            Contact.Add("State", "Uttar Pradesh");
            Contact.Add("PhoneNumber", "9897139203");
            Contact.Add("Email", "Amitkr2403@gmail.com");

            foreach (var element in Contact)
            {
                Console.WriteLine("{0}:  {1}", element.Key, element.Value);
            }
        }
    }
}
