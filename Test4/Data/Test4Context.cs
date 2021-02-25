using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test4.Models;

namespace Test4.Data
{
    public class Test4Context : DbContext
    {
        public Test4Context (DbContextOptions<Test4Context> options)
            : base(options)
        {
        }

        public DbSet<Test4.Models.User> User { get; set; }
    }
}
