using InventoryManagement.Service.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Transaction
{
    public class PurchaseTransactionDto
    {
        public long PartnerId { get; set; }
        public DateTime TransactionDate { get; set; }
        
        public  ICollection<PurchaseTransactionLineDto> _TransactionLines { get; set; }
        //public  ICollection<TransactionLineDto> _TransactionLines { get; set; }
    }
}
