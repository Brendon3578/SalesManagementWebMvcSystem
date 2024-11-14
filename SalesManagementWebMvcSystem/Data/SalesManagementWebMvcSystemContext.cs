using Microsoft.EntityFrameworkCore;
using SalesManagementWebMvcSystem.Models;

namespace SalesManagementWebMvcSystem.Data
{
    public class SalesManagementWebMvcSystemContext : DbContext
    {
        public SalesManagementWebMvcSystemContext(DbContextOptions<SalesManagementWebMvcSystemContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
    }
}
