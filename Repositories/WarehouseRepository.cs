using GRitiD.Data;
using GRitiD.Models;
using GRitiD.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GRitiD.Repositories
{
    internal class WarehouseService : IWarehouseRepository
    {
        private readonly ApiContext _dbContext;

        public WarehouseService(ApiContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public IActionResult SetProductCapacity(int productId, int capacity)
        {
             _dbContext.Add(new Product { productId = productId, capacity = capacity, qty = 0 });
            _dbContext.SaveChanges();
            return new OkResult();
        }

        public IActionResult UpdateProductQty(int productId, int qty)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.productId == productId);
            product.qty = qty;
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return new OkResult();
        }
    }
}
