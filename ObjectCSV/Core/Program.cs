using ObjectCSV.Repository;
using System;
using System.Collections.Generic;

namespace ObjectCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvConfig = new CSVConfig();

            var person = new List<Person>
            {
                new Person { Id = 1, Name = "Joaquim", BirthDate = DateTime.Parse("05/10/1984 12:00:30 PM"), Size = 1.50 },
                new Person { Id = 2, Name = "Joker", BirthDate = DateTime.Parse("6/11/1964 2:20:34 AM"), Size = 1.50 },
                new Person { Id = 3, Name = "Phoenix", BirthDate = DateTime.Parse("9/2/1999 10:54:45 AM"), Size = 1.50 }
            };

            Console.WriteLine("Path with file name: ");
            string pathPerson = Console.ReadLine();

            csvConfig.WriteOnCSV(person, pathPerson);

            Console.WriteLine("\n\nData exported sucessfuly.");
            Console.ReadKey();
        }
    }
}
