using System;
using System.Collections.Generic;
using System.Linq;

namespace Tech_Boost_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] FileContent = new TextFileReader().Read("./unsorted-names-list.txt");
            List<Person> PersonList = new List<Person>();
            foreach (string ln in FileContent)
            {
                string[] pair = ln.Split(",", StringSplitOptions.RemoveEmptyEntries);
                if (pair.Length == 2)
                {
                    pair[0] = pair[0].Trim();
                    pair[1] = pair[1].Trim().ToUpper();
                    if (!pair.Contains(""))
                        PersonList.Add(new Person(pair[0], pair[1]));
                }

            }

            Console.WriteLine("1. Ordered by Name\n");
            List<Person> SortedByName = PersonList.OrderBy(o => o.Name).ToList();
            foreach (Person p in SortedByName)
                Console.WriteLine(p);

            Console.WriteLine("\n\n2. Ordered by Role\n");
            List<Person> SortedByRole = PersonList.OrderBy(o => o.Role).ToList();
            foreach (Person p in SortedByRole)
                Console.WriteLine(p);


        }
    }
}
