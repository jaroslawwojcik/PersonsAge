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
            var ageAsString = Console.ReadLine();
            var age = ValidateAge(ageAsString);

            return new Person
            {
                Name = name,
                Age = age
            };
        }
        private int ValidateAge(string ageAsString)
        {
            int age;
            while (!int.TryParse(ageAsString, out age))
            {
                Console.WriteLine("Not a valid number, try again.");

                ageAsString = Console.ReadLine();
            }
            return age;
        }
}
}
