using Microsoft.EntityFrameworkCore;
using SalesManagementWebMvcSystem.Data;
using SalesManagementWebMvcSystem.Models;

namespace SalesManagementWebMvcSystem.Services
{
    public class DepartmentService
    {
        private readonly SalesManagementWebMvcSystemContext _context;
        public DepartmentService(SalesManagementWebMvcSystemContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync() => await _context.Department.OrderBy(x => x.Name).ToListAsync();
    }
}
