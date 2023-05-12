using GRitiD.Models;
using Microsoft.AspNetCore.Mvc;

namespace GRitiD.Repositories.Interfaces
{
    public interface IWarehouseRepository
    {
        public IEnumerable<Product> GetProducts();
        public IActionResult SetProductCapacity(int productId, int capacity);
        public IActionResult UpdateProductQty(int productId, int qty);
    }
}
