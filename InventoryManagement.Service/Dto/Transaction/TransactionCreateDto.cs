using InventoryManagement.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Transaction
{
     public  class TransactionCreateDto
    {
        public long PartnerId { get; set; }
        public virtual ICollection<TransactionLineDto> _TransactionLines { get; set; }

    }
}
