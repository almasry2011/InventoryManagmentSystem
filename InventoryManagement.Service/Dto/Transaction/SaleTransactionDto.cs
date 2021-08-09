using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Transaction
{
   public class SaleTransactionDto  
    {
        public long PartnerId { get; set; }
        public DateTime TransactionDate { get; set; }
        public ICollection<SaleTransactionLineDto> _TransactionLines { get; set; }

    }
}
