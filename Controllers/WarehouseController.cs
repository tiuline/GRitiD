using GRitiD.Models.Dtos;
using GRitiD.Repositories.Interfaces;
using GRitiD.Servces.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GRitiD.Controllers
{
    [ApiController]
    [Route("Warehouse")]
    public class WarehouseController : ControllerBase
    {
        private readonly ILogger<WarehouseController> _logger;
        private readonly IWarehouseRepository _warehouseRepository;
        private readonly IWarehouseService _warehouseService;

        public WarehouseController(ILogger<WarehouseController> logger, IWarehouseRepository warehouseRepository, IWarehouseService warehouseService)
        {
            _logger = logger;
            _warehouseRepository = warehouseRepository;
            _warehouseService = warehouseService;
        }

        // Return OkObjectResult(IEnumerable<WarehouseEntry>)
        [HttpGet]
        [Route("getProducts")]
        public IActionResult GetProducts()
        {
            try
            {
                return new OkObjectResult(_warehouseRepository.GetProducts());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // define Autorize
        [HttpPost]
        [Route("setProductCapacity")]
        public IActionResult SetProductCapacity([FromBody] SetProductCapacityDto obj)
        {
            try
            {
                return new OkObjectResult(_warehouseService.SetProductCapacity(obj.productId, obj.capacity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // define Autorize
        [HttpPost]
        [Route("recieveProduct")]
        public IActionResult ReceiveProduct([FromBody]UpdateProductDto obj)
        {
            try
            {
                return new OkObjectResult(_warehouseService.ReceiveProduct(obj.productId, obj.qty));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // define Autorize
        [HttpPost]
        [Route("dispatchProduct")]
        public IActionResult DispatchProduct([FromBody] UpdateProductDto obj)
        {
            try
            {
                return new OkObjectResult(_warehouseService.DispatchProduct(obj.productId, obj.qty));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}