using GRitiD.Models;
using Microsoft.AspNetCore.Mvc;

namespace GRitiD.Servces.Interfaces
{
    public interface IWarehouseService
    {
        public IActionResult SetProductCapacity(int productId, int capacity);
        public IActionResult ReceiveProduct(int productId, int qty);
        public IActionResult DispatchProduct(int productId, int qty);
    }
}
