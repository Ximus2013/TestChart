using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestChart.DB;
using TestChart.Interfaces;
using TestChart.Models;

namespace TestChart.Repository
{
    public class PersonRepository : IPerson
    {
        private readonly AppDBContent appDBContent;
        public PersonRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }





        public IEnumerable<Person> Persons => appDBContent.Person;

        public Person getObjectPerson(int PersonID) => appDBContent.Person.FirstOrDefault(p => p.id == PersonID);
    }
}
