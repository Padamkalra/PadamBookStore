using PadamBookStore.DataAccess.Repository.IRepository;
using PadamBookStore.Models;
using PadamBookStore.DataAccess.Data;
using PadamBookStore.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PadamBookStore.DataAccess.Repository
{

    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        /*
                public object GetAll()
                {
                    throw new NotImplementedException();
                }*/



        public void Update(CoverType covertype)
        {
            //throw new NotImplementedException();
            //use .NET LINQ to retrieve the first or default category object
            // then pass the id as a generic entity which matters the category ID
           
            {
                var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == covertype.Id);
                if(objFromDb != null)
                {
                    objFromDb.Name = covertype.Name;
                }
                
                //_db.SaveChanges();
                //_unitOfWork.save();
            }
        }

        /* public void Update(CoverType CoverType)
         {
             throw new NotImplementedException();
         }*/
    }

}