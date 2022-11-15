using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PadamBookStore.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id); //Retrieve a category from the database.by id /. List of Categories based on requirements
        // list of Categories based on cmoponents

       IEnumerable<T> GetAll(
           Expression<Func<T, bool>> filter = null,
              Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                 string includeProperties = null   // useful for foreign key references
            );
        void Add(T entity); // to add an entity

        void Remove(int id);  // to remove an object or catgeory 

        void Remove(T entity); // another way to remove an object 

        void RemoveRange(IEnumerable<T> entity); // removes a complete range of entities


    }
}
