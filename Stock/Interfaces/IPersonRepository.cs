using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    interface IPersonRepository
    {
        void AddPerson(Person p);
        void EditPerson(Person p);
        void RemovePerson(int Id);
        IEnumerable<Person> GetPersons();
        Person FindPersonById(int Id);
    }
}
