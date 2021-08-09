using InventoryManagement.Domain.Enum;
using InventoryManagement.Service.Dto.Partner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Transaction
{
   public class TransactionDto : EntityDto<long>
    {
        public decimal Total { get;   set; }
        public TransactionType TransactionType { get;   set; }

        public long PartnerId { get;   set; }

        public string PartnerName { get; set; }
        public string PhoneNumber { get; set; }
        public int ProductsCount { get; set; }
 
        public  PartnerDto Partner { get; private set; }
        public virtual ICollection<TransactionLineDto> _TransactionLines { get; set; }

    }



    public class TransactionLitsDto : EntityDto<long>
    {
        public decimal Total { get; set; }
        public long TransactionTypeId { get; set; }
        public string TransactionTypeStr { get; set; }
        public string TransactionDate { get; set; }

        public long PartnerId { get; set; }

        public string PartnerName { get; set; }
        public string PhoneNumber { get; set; }
        public int ProductsCount { get; set; }

        public decimal  Profit { get; set; }
        //public decimal WholesaleProfit { get; set; }
        //public decimal SegmentalProfit { get; set; }


    }










}
