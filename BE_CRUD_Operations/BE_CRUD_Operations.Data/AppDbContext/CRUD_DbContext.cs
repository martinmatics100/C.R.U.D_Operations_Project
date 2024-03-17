using BE_CRUD_Operations.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_CRUD_Operations.Data.AppDbContext
{
    public class CRUD_DbContext : DbContext
    {
        public CRUD_DbContext(DbContextOptions<CRUD_DbContext> options) : base(options)
        {
        }

        public DbSet<Student> students { get; set; }
    }
}
