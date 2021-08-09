using InventoryManagement.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Transaction
{
    public class TransactionFilterDto
    {
        public decimal? Total { get; set; }
        public TransactionType TransactionType { get; set; }
        public long? PartnerId { get; set; }
    }
}
