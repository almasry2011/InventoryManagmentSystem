using InventoryManagement.Service.Contract;
using System;

namespace InventoryManagement.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}