using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ZEYNEP\\SQLEXPRESS;database=ToDoListDB;integrated security=true");
        
        }
        public DbSet<Gorev> Gorevs { get; set; }  
        public DbSet<User> Users { get; set; }

    }
}
