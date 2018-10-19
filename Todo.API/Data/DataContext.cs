using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todo.API.Models;

namespace Todo.API.Data
{
    public class DataContext : DbContext
    {
        protected DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
    }
}
