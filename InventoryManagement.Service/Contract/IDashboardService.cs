using InventoryManagement.Service.Dto.Dashboard;

namespace InventoryManagement.Service.Contract
{
    public interface IDashboardService
    {
        DashboardModelDto GetDashboardData ();
    }
}