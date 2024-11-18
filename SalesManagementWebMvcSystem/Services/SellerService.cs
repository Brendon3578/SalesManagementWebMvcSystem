﻿using SalesManagementWebMvcSystem.Data;
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
    }
}