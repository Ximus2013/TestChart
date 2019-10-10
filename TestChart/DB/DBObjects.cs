using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestChart.Models;

namespace TestChart.DB
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Person.Any())
                content.AddRange(
                    new Person { Name = "Ivanov", Active = true },
                new Person { Name = "Petrov", Active = false },
                new Person { Name = "Sidorov", Active = true },
                new Person { Name = "Kirilov", Active = false },
                new Person { Name = "Portnov", Active = true }
                     );
            content.SaveChanges();
        }

    }
}
