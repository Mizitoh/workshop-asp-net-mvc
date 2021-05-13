using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SellesWebMvc.Models;

namespace SellesWebMvc.Data
{
    public class SellesWebMvcContext : DbContext
    {
        public SellesWebMvcContext (DbContextOptions<SellesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SellesWebMvc.Models.Department> Department { get; set; }
    }
}
