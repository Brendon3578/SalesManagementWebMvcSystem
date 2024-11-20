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

        public Seller FindById(int id) => _context.Seller.First(x => x.Id == id);

        public void Remove(int id)
        {
            var s = _context.Seller.Find(id);
            _context.Seller.Remove(s);
            _context.SaveChanges();
        }
    }
}
