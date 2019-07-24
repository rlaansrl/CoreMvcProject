using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreMvcProject.Models
{
    public class CoreMvcProjectContext : DbContext
    {
        public CoreMvcProjectContext (DbContextOptions<CoreMvcProjectContext> options)
            : base(options)
        {
        }

        public DbSet<CoreMvcProject.Models.User> User { get; set; }
    }
}
