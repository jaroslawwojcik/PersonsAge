using PeopleAge.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleAge.Factories
{
    class PersonFactory
    {
        public Person CreatePerson()
        {
            Console.WriteLine("Creating Person...");
            Console.WriteLine("Please enter name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter age");
            var age = int.Parse(Console.ReadLine());

            return new Person
            {
                Name = name,
                Age = age
            };
        }
    }
}
