using GRitiD.Data;
using GRitiD.Models;
using GRitiD.Repositories.Interfaces;
using GRitiD.Servces.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GRitiD.Servces
{
    internal class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseRepository _warehouseRepository;

        public WarehouseService(IWarehouseRepository warehouseRepository) 
        {
            _warehouseRepository = warehouseRepository;
        }

        // Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooLowMessage)
        public IActionResult SetProductCapacity(int productId, int capacity)
        {
            if (capacity < 1)
                return new BadRequestObjectResult(Enums.Messages.NotPositiveQuantityMessage);

            else if (capacity > 20)
                return new BadRequestObjectResult(Enums.Messages.QuantityTooHighMessage);
            
            _warehouseRepository.SetProductCapacity(productId, capacity);
            return new OkResult();
        }

        // Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooHighMessage)
        public IActionResult ReceiveProduct(int productId, int qty)
        {
            if (qty < 1)
                return new BadRequestObjectResult(Enums.Messages.NotPositiveQuantityMessage);
            else if (qty > 20)
                return new BadRequestObjectResult(Enums.Messages.QuantityTooHighMessage);
            
            _warehouseRepository.UpdateProductQty(productId, qty);
            return new OkResult();
        }

        // Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooHighMessage)
        public IActionResult DispatchProduct(int productId, int qty)
        {
            if (qty < 1)
                return new BadRequestObjectResult(Enums.Messages.NotPositiveQuantityMessage);
            else if (qty > 20)
                return new BadRequestObjectResult(Enums.Messages.QuantityTooHighMessage);

            _warehouseRepository.UpdateProductQty(productId, qty);
            return new OkResult();
        }
    }
}
