using InventoryManagement.Domain.Settings;
using InventoryManagement.Service.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/Dashboard")]
    [ApiVersion("1.0")]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }
        [HttpGet("GetDashboardData")]
        public   IActionResult  GetDashboardData( )
        {
            var res = _dashboardService.GetDashboardData();
            return Ok(res);
        }

    }
}