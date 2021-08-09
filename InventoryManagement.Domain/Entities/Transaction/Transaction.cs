using InventoryManagement.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Domain.Entities
{
   public class Transaction:BaseEntity<long>
    {

        [Column(TypeName = "decimal(18,4)")]
        public decimal Total { get; private set; }
        public  TransactionType TransactionType { get; private set; }
        public DateTime TransactionDate { get; private set; }

        public long PartnerId { get; private set; }
        [ForeignKey("PartnerId")]
        public virtual Partner Partner { get; private set; }

        public virtual IReadOnlyCollection<TransactionLine> TransactionLines => _transactionLines;

        private List<TransactionLine> _transactionLines = new List<TransactionLine>();

        public Transaction() { } 
        public Transaction(TransactionType trxtype, long partnerId, DateTime transactionDate)
        {
            TransactionType = trxtype;
             PartnerId = partnerId;
            TransactionDate = transactionDate;
        }
        public void AddTransactionLine(ProductDetails productDtl, int qty)
        {
            var trxLine = new TransactionLine
            {
               // ProductDetailId = productDtl.Id,
               // ProductDetail = product,
                Quantity = qty,
                //UnitPrice = productDtl.UnitPrice,
               Transaction=this
            };
            _transactionLines.Add(trxLine);

          //  productDtl.Product.RecordTransaction(this);
          //  Total = _transactionLines.Sum(s => s.UnitPrice * s.Quantity);
        }


        public void AddPurchaseTransactionLine(TransactionLine line)
        {
            var trxLine = new TransactionLine
            {
 
                Quantity = (line.Product.ItemsInBox * line.BoxNumbers) ,
                SellingBoxPrice= line.Product.SellingBoxPrice,
                SellingUnitPrice= line.Product.SellingUnitPrice,

                ProductId = line.ProductId,

                BuyingBoxPrice = line.BuyingBoxPrice/ line.BoxNumbers,
                BuyingUnitPrice =   (line.BuyingUnitPrice / line.BoxNumbers)  / line.Product.ItemsInBox,
                
                BoxNumbers=line.BoxNumbers,
                BuyingPrice= line.BuyingPrice,

                Transaction = this
            };
            _transactionLines.Add(trxLine);

            Total = _transactionLines.Sum(s => s.BuyingPrice);

            line.Product.RecordTransaction(trxLine, TransactionType.Purchase);
            line.Product.SetWholesalePrice(trxLine);





            //unitpriceWholesale
            //      product.AddProductDetails(productDtl);


            //  product.RecordTransaction(this);
            //   Total = _transactionLines.Sum(s => s.UnitPrice * s.Quantity);
        }

        public void AddSaleTransactionLine(TransactionLine line)
        {
            var trxLine = new TransactionLine
            {
              //  ProductDetailId = productDtl.Id,
                Quantity = line.Quantity ,
                Box = line.Box,
                SellingBoxPrice = line.Product.SellingBoxPrice,
                SellingUnitPrice = line.Product.SellingUnitPrice,
                BuyingPrice= line.BuyingPrice,
                ProductId=line.ProductId,
                BoxNumbers = (line.Box.HasValue && line.Box.Value ) ? (line.Quantity / line.Product.ItemsInBox) : 0 ,
                Transaction = this
            };
            _transactionLines.Add(trxLine);
            Total = _transactionLines.Sum((s) => (s.Box.HasValue && s.Box.Value) ? s.BoxNumbers * line.Product.SellingBoxPrice :
            s.Quantity * s.SellingUnitPrice);
            line.Product.RecordTransaction(line, TransactionType.Sales);
        }


        
        //public decimal CalculateWholeSaleProfitForPurchase()
        //{
        //    return _transactionLines.Sum( s =>   (s.BoxNumbers * s.SellingBoxPrice) -  (s.BuyingPrice) )   ;
        // }

        //public decimal CalculateSegmentalProfitForPurchase()
        //{
        //    decimal sum = 0;
        //    foreach (var item in _transactionLines)
        //    {
        //        var buyingBoxPrice = item.BuyingPrice / item.BoxNumbers;
        //        var unitPriceWholeSale = buyingBoxPrice / item.Product.ItemsInBox;

        //        sum += item.Product.SellingUnitPrice - unitPriceWholeSale;
 
        //    }
        //    return _transactionLines.Sum(s => ( (s.Product.SellingUnitPrice) - (  (s.BuyingPrice/s.BoxNumbers) / s.Product.ItemsInBox) ) *  (s.BoxNumbers * s.Product.ItemsInBox)  );
        //}

        public decimal CalculateTrxProfit(TransactionType trxType   )
        {
            decimal sum = 0;
            if (trxType==TransactionType.Purchase)
            {
                sum = _transactionLines.Sum(s => (s.BoxNumbers * s.SellingBoxPrice) - (s.BuyingPrice));
            }
            else
            {
                foreach (var item in _transactionLines)
                {

                    if (item.Box == true)
                    {
                        sum = item.Quantity * item.Product.GetBoxProfit();
                    }
                    else
                    {
                        sum = item.Quantity * item.Product.GetUnitProfit();
                    }
                }
                var p1 = _transactionLines.Where(s => s.Box == true).Sum(s => (s.Quantity * s.Product.GetBoxProfit()));
                var p2 = _transactionLines.Where(s => s.Box == true).Sum(s => (s.Quantity * s.Product.GetUnitProfit()));

            }





            return sum;

        }
            //private Expression<Func<Product, bool>> BuildSearchPredicate(ProductFilterDto filter, string search)
            //{
            //    var predicate = PredicateBuilder.New<Product>(true); // Eq - Expression<Func<Product, bool>> predicate = c => true;

            //    if (!string.IsNullOrEmpty(filter?.Name))
            //    {
            //        predicate.And(s => s.Name.Contains(filter.Name));
            //    }


            //    //public decimal CalculateWholeSaleUnitPrice(ProductDetails productDtl )
            //    //{
            //    //    var boxPrice = productDtl.bu /
            //    //    return ProductDetails != null ? 0 : ProductDetails.FirstOrDefault().UnitPrice;
            //    //}


            //}




        }
    }
