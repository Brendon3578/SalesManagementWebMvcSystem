using Microsoft.EntityFrameworkCore;
using SalesManagementWebMvcSystem.Data;
using SalesManagementWebMvcSystem.Models;

namespace SalesManagementWebMvcSystem.Services
{
    public class SellerService
    {
        private readonly SalesManagementWebMvcSystemContext _context;

        public SellerService(SalesManagementWebMvcSystemContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() => _context.Seller.ToList();

        public void Insert(Seller newSeller)
        {
            _context.Add(newSeller);
            _context.SaveChanges();
        }

        public Seller? FindById(int id)
        {
            return _context.Seller
                .Include(obj => obj.Department)
                .FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var s = _context.Seller.Find(id);
            _context.Seller.Remove(s);
            _context.SaveChanges();
        }
    }
}
