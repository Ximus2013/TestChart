using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestChart.Models;

namespace TestChart.Interfaces
{
    public interface IPerson
    {
        IEnumerable<Person> Persons { get;}
        Person getObjectPerson (int id);
    }
}
