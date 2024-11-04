using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesManagementWebMvcSystem.Models;

namespace SalesManagementWebMvcSystem.Data
{
    public class SalesManagementWebMvcSystemContext : DbContext
    {
        public SalesManagementWebMvcSystemContext (DbContextOptions<SalesManagementWebMvcSystemContext> options)
            : base(options)
        {
        }

        public DbSet<SalesManagementWebMvcSystem.Models.Department> Department { get; set; } = default!;
    }
}
