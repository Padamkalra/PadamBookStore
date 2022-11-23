using PadamBookStore.DataAccess.Repository.IRepository;
using PadamBookStore.Models;
using PadamBookStore.DataAccess.Data; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PadamBookStore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository

    {

        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // use.Net LINQ to retrive the first or default category object,
            // then pass the id as a genirc entity which mathces the category Id
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) // save the changes if not null
            {
                objFromDb.Name = category.Name;
                //  _db.SaveChanges();
                //_unitOfWork.save();
            }
        }

    }
}
            
        
    

