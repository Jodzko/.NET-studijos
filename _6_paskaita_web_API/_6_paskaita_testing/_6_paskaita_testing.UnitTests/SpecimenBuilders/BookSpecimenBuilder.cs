using _6_paskaita_testing.Models;
using AutoFixture.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _6_paskaita_testing.UnitTests.SpecimenBuilders
{
    internal class BookSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            if(request is Type type && type == typeof(Book))
            {
                return new Book { Title = "LOTR", ISBN = "999", Price = 99 };
            }
            return new NoSpecimen();
        }
    }
}
