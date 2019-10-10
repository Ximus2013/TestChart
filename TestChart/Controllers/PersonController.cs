using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestChart.Interfaces;

namespace TestChart.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPerson _persons;

        public PersonController(IPerson ipersons)
        {
            _persons = ipersons;
        }
        public ViewResult List()
        {
            var persons = _persons.Persons;
            return View(persons);
        }
    }
}
