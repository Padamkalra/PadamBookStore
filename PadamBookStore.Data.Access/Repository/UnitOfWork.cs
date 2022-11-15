using PadamBookStore.DataAccess.Repository.IRepository;
using PadamBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadamBookStore.DataAccess.Repository
{
    public class UnitOfwork //make the method public to  accesss the class
    {
        private readonly ApplicationDbContext _db; //using the statemnt

        public UnitOfwork(ApplicationDbContext db) //constructor to uswe the ID and inject in to the repositories 
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }
         public ICategoryRepository Category { get; private set;  }

         public ISP_Call SP_Call { get; private set; } 
    }

}
