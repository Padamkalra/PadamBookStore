using PadamBookStore.DataAccess.Repository.IRepository;
using PadamBookStore.Models;
using PadamBookStore.DataAccess.Data; 
using System;
using System.Collections.Generic;
using System.Text;

namespace PadamBookStore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, PadamBookStore.DataAccess.Repository.IRepository.ICategoryRepository

    {

        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        
        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
