using PadamBookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadamBookStore.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
