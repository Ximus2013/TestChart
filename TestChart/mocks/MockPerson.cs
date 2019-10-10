using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestChart.Interfaces;
using TestChart.Models;

namespace TestChart.mocks
{
    public class MockPerson : IPerson {   

    
        public IEnumerable<Person> Persons
    {
        get
        {
                return new List<Person>
            {
                new Person{ Name ="Ivanov", Active = true},
                new Person{ Name ="Petrov", Active = false},
                new Person{ Name ="Sidorov", Active = true},
                new Person{ Name ="Kirilov", Active = false},
                new Person{ Name ="Portnov", Active = true}
            };


        }

    }

        public Person getObjectPerson(int id)
        {
            throw new NotImplementedException();
        }
    }
}
