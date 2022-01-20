using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable app = new Hashtable();

            app.Add("1", "Hello World");
            app.Add("2", "Hello My World");

            foreach (DictionaryEntry item in app)
            {
                Console.WriteLine(item.Key + " "+item.Value);
            }
            Console.ReadLine();
        }
    }
}
