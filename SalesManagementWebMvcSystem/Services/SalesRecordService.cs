using Microsoft.EntityFrameworkCore;
using SalesManagementWebMvcSystem.Data;
using SalesManagementWebMvcSystem.Models;

namespace SalesManagementWebMvcSystem.Services
{
    public class SalesRecordService
    {
        private readonly SalesManagementWebMvcSystemContext _context;

        public SalesRecordService(SalesManagementWebMvcSystemContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
                result = result.Where(x => x.Date >= minDate.Value);
            if (maxDate.HasValue)
                result = result.Where(x => x.Date <= maxDate.Value);
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
