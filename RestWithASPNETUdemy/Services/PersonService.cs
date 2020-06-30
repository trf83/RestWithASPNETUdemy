using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Services
{
    class PersonService : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public Person FindById(long id)
        {
            return new Person()
            {
                Id = 1,
                FistName = "Thiago",
                LastName = "Reis",
                Address = "Matão",
                Gender = "M"
            };
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (long i = 0; i < 8; i++)
            {
                persons.Add(new Person()
                {
                    Id = i,
                    FistName = "Thiago " + i,
                    LastName = "Reis " + i,
                    Address = "Matão",
                    Gender = "M"
                });
            }

            return persons;
        }

        public Person Update(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }
    }


}
