using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFConfigureServices
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }
    }

    public class Blog
    {
        public int Id { get; set; }
    }
}
