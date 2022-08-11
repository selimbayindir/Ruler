using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        IPerson _person;

        public PersonManager(IPerson person)
        {
            _person = person;
        }

        public void Add(Person person)
        {
             _person.Add(person);

        }

        public void Delete(Person person)
        {
            
            _person.Delete(person);
        }

        public List<Person> GetPeople()
        {
            return _person.GetAll();
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
