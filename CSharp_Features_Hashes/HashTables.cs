using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Features_Hashes
{
    class HashTables
    {
        public static void HashTables_VerySimpleExample()
        {
            Hashtable ht = new Hashtable();

            ht.Add("001", "Peter Forsberg");
            ht.Add("002", "Joe Sakic");
            ht.Add("003", "Adam Foote");
            ht.Add("004", "Patrick Roy");
            ht.Add("005", "Adam Deadmarsh");
            ht.Add("006", "Milan Hejduk");
            ht.Add("007", "Rob Blake");
            ht.Add("008", "Sean Podein");
            ht.Add("009", "Chris Drury");
            ht.Add("010", "Mike Keane");

            if (ht.ContainsValue("Valerie Komensky"))
            {
                Console.WriteLine("Valerie Komensky is already in the table.");
            }
            else
            {
                ht.Add("011", "Valerie Komensky");
            }

            if (ht.ContainsValue("Peter Forsberg"))
            {
                Console.WriteLine("Peter Forsberg is already in the table.");
            }

            // Get a collection of the keys
            ICollection keys = ht.Keys;

            foreach (string key in keys)
            {
                Console.WriteLine(key + ": " + ht[key]);
            }
        }
    }
}
