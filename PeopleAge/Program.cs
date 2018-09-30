using PeopleAge.Factories;
using PeopleAge.Model;
using PeopleAge.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleAge
{
    class Program
    {
        private static PersonsRepository _personsReopsitory = new PersonsRepository();
        private static PersonFactory _personFactory = new PersonFactory();
        private static readonly List<Person> _allPersons = _personsReopsitory.GetList();

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                MainMenu();
                var option = Console.ReadKey(true).Key;
                switch (option)
                {
                    case ConsoleKey.D1:
                         var createdPerson = _personFactory.CreatePerson();
                        _personsReopsitory.AddPerson(createdPerson);
                        break;
                    case ConsoleKey.D2:
                        PrintAscending(_allPersons);
                        
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Please enter searched age");
                        var age = int.Parse(Console.ReadLine());
                        PrintOccuranceOfGivenAge(_allPersons, age);
                        break;
                    case ConsoleKey.D4:
                        PrintAllPersons(_allPersons);
                        break;
                        
                }
                
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        private static void PrintAllPersons(ICollection<Person> collection)
        {
            foreach(var person in collection)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }

        private static void PrintOccuranceOfGivenAge(ICollection<Person> collection, int age)
        {
            var collectionOfPersons = collection.FirstOrDefault(x=> x.Age == age);
            
            if (collectionOfPersons != null)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        static void MainMenu()
        {
            Console.WriteLine("Welcome to program that do something with people's age :)");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1) Add person");
            Console.WriteLine("2) Display persons older than 18 or equal (ascending)");
            Console.WriteLine("3) Chceck if there is a person with given name");
            Console.WriteLine("4) Print all persons");
                
        }

        private static void PrintAscending(ICollection<Person> collection)
        {
            var collectionOfPersons = collection.Where(x => x.Age >= 18).OrderBy(x=> x.Age).ToList();
            foreach (var person in collectionOfPersons)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
