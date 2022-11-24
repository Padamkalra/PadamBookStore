using PadamBookStore.DataAccess.Repository.IRepository;
using PadamBookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadamBookStore.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>

    {
        void Update(Product product);

    }
}
