// Added using of the models 
using PadamBookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

//Changed the namespace here
namespace PadamBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //added new statement which was given in the PPT
        public  DbSet<Category> Categories { get; set; }
        
        public DbSet<CoverType> CoverTypes { get; set; }

        public DbSet<Product> Products { get; set; }  //adding products to the DB
    }
}
