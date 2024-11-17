using SalesManagementWebMvcSystem.Models;
using SalesManagementWebMvcSystem.Models.Enums;

namespace SalesManagementWebMvcSystem.Data
{
    public class SeedingService
    {
        private SalesManagementWebMvcSystemContext _context;

        public SeedingService(SalesManagementWebMvcSystemContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            bool hasAnyDepartmentCreated = _context.Department.Any();
            bool hasAnySellerCreated = _context.Seller.Any();
            bool hasAnySalesCreated = _context.SalesRecord.Any();

            if (hasAnyDepartmentCreated || hasAnySalesCreated || hasAnySellerCreated)
                return; // DB has been seeded

            // Não definir os campos de IDs quando for instanciar os objetos,
            // Por causa da regra IDENTITY_INSERT do SQL Server que é desabilitada por default
            var d1 = new Department { Name = "Computers" };
            var d2 = new Department { Name = "Electronics" };
            var d3 = new Department { Name = "Fashion" };
            var d4 = new Department { Name = "Books" };

            // Criar vendedores
            var s1 = new Seller { Name = "Bob Brown", Email = "bob@gmail.com", BirthDate = new DateTime(1998, 4, 21), BaseSalary = 1000.0, Department = d1 };
            var s2 = new Seller { Name = "Alice Green", Email = "alice@gmail.com", BirthDate = new DateTime(1985, 6, 15), BaseSalary = 1500.0, Department = d2 };
            var s3 = new Seller { Name = "John Blue", Email = "john@gmail.com", BirthDate = new DateTime(1990, 1, 9), BaseSalary = 1200.0, Department = d3 };
            var s4 = new Seller { Name = "Maria White", Email = "maria@gmail.com", BirthDate = new DateTime(1995, 11, 30), BaseSalary = 1100.0, Department = d4 };
            var s5 = new Seller { Name = "Carlos Black", Email = "carlos@gmail.com", BirthDate = new DateTime(1988, 8, 25), BaseSalary = 1300.0, Department = d2 };

            // Criar registros de vendas
            var r1 = new SalesRecord { Date = new DateTime(2018, 09, 25), Amount = 11000.0, Status = SalesStatus.Billed, Seller = s1 };
            var r2 = new SalesRecord { Date = new DateTime(2018, 09, 26), Amount = 7000.0, Status = SalesStatus.Pending, Seller = s1 };
            var r3 = new SalesRecord { Date = new DateTime(2018, 09, 27), Amount = 4000.0, Status = SalesStatus.Canceled, Seller = s2 };
            var r4 = new SalesRecord { Date = new DateTime(2018, 10, 01), Amount = 8000.0, Status = SalesStatus.Billed, Seller = s3 };
            var r5 = new SalesRecord { Date = new DateTime(2018, 10, 02), Amount = 9500.0, Status = SalesStatus.Billed, Seller = s3 };
            var r6 = new SalesRecord { Date = new DateTime(2018, 10, 03), Amount = 12000.0, Status = SalesStatus.Pending, Seller = s4 };
            var r7 = new SalesRecord { Date = new DateTime(2018, 10, 04), Amount = 15000.0, Status = SalesStatus.Billed, Seller = s4 };
            var r8 = new SalesRecord { Date = new DateTime(2018, 10, 05), Amount = 2000.0, Status = SalesStatus.Canceled, Seller = s5 };
            var r9 = new SalesRecord { Date = new DateTime(2018, 10, 06), Amount = 17500.0, Status = SalesStatus.Billed, Seller = s5 };
            var r10 = new SalesRecord { Date = new DateTime(2018, 10, 07), Amount = 2500.0, Status = SalesStatus.Pending, Seller = s1 };
            var r11 = new SalesRecord { Date = new DateTime(2018, 10, 08), Amount = 10000.0, Status = SalesStatus.Billed, Seller = s2 };
            var r12 = new SalesRecord { Date = new DateTime(2018, 10, 09), Amount = 5000.0, Status = SalesStatus.Billed, Seller = s3 };
            var r13 = new SalesRecord { Date = new DateTime(2018, 10, 10), Amount = 9000.0, Status = SalesStatus.Pending, Seller = s4 };
            var r14 = new SalesRecord { Date = new DateTime(2018, 10, 11), Amount = 3000.0, Status = SalesStatus.Billed, Seller = s5 };
            var r15 = new SalesRecord { Date = new DateTime(2018, 10, 12), Amount = 4000.0, Status = SalesStatus.Pending, Seller = s4 };


            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15);

            _context.SaveChanges();


        }
    }
}
