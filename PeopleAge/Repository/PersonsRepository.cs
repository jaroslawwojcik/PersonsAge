using PeopleAge.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PeopleAge.Repository
{
    class PersonsRepository 
    {
        private List<Person> _personsList = new List<Person>();

        public void AddPerson(Person person)
        {
            _personsList.Add(person);
        }

        public List<Person> GetList()
        {
            return _personsList;
        }
    }
}
