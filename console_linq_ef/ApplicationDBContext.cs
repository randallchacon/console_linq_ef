using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq_ef
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite($"Data source=dbLinq.db");
            optionsBuilder.UseSqlServer(dbConn.connection); //Ex: "Data Source=MyPC\\SQLEXPRESS01;Initial Catalog=dbLinq;user id=usuario; password=123";
        }

        public DbSet<Person> People { get; set; }
    }
}
