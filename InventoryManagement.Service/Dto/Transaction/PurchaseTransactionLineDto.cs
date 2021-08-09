using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Transaction
{
  public  class PurchaseTransactionLineDto : EntityDto<long>
    {
            public long TransactionId { get; set; }
            public int BoxNumbers { get;  set; }
            public decimal BuyingPrice { get;  set; }
            public DateTime ExpiryDate { get; set; }
            public DateTime ProductionDate { get; set; }
            public long ProductId { get; init; }
    }
}
