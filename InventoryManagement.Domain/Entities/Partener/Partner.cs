using InventoryManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using InventoryManagement.Domain.Enum;

namespace InventoryManagement.Domain.Entities
{
   public class Partner:BaseEntity<long>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; private set; }   
        [Required]
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }

        [Required]
        public Address Address { get; private set; }

        public virtual IReadOnlyCollection<Transaction> Transactions => _transactions.AsReadOnly();
        private List<Transaction> _transactions = new List<Transaction>();

        public Partner()
        {

        }
        public Partner(string Name, Address Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public void UpdateAddress(Address Address)
        {
            this.Address = Address;
        }
        ///// <summary>
        ///// Generate a new sales transaction with this partner.
        ///// </summary>
        //public Transaction SellTo(IEnumerable<(Products.Product product, int quantity)> items)
        //    => CreateTransaction(items, TransactionType.Sales);


        ///// <summary>
        ///// Generate a new procurement transaction with this partner.
        ///// </summary>
        //public Transaction ProcureFrom(IEnumerable<(Products.Product product, int quantity)> items)
        //    => CreateTransaction(items, TransactionType.Procurement);


        //public Transaction CreateTransaction(IEnumerable<(Product product, int quantity)> items, TransactionType transactionType)
        //    {
        //       var transaction = new Transaction(transactionType, this.Id);
        //            foreach (var item in items)
        //            {
        //                transaction.AddTransactionLine(item.product, item.quantity);
        //            }
        //    _transactions.Add(transaction);
        //    return transaction;
        //    }



       
        }
}
