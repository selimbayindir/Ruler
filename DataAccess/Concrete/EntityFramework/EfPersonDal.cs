using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entity.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal : IPerson
    {
        public void Add(Person person)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var addedEntity = context.Entry(person);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

     

        public void Delete(Person person)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var deletedEntry = context.Entry(person);
                deletedEntry.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Person Get(Expression<Func<Person, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll(Expression<Func<Person, bool>> filter = null)
        {
            using (NortwindContext context =new NortwindContext())
            {
                return filter ==null
                    ? context.Set<Person>().ToList()
                    :context.Set<Person>().Where(filter).ToList();
            }
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
