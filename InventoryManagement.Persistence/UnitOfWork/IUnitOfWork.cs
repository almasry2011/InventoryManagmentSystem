using InventoryManagement.Domain.Entities;
using InventoryManagement.Persistence.Repository;
using System;
using System.Threading.Tasks;

namespace InventoryManagement.Persistence.UnitOfWork
{
    public interface IUnitOfWork<T, PK> : IDisposable where T : class
    {
        IRepository<T, PK> Repository { get; }
        IRepository<Product, long> _productRepo { get; }
        IRepository<ProductDetails, long> _productDetailsRepo { get; }
        IRepository<Category, long> _categoryRepo { get; }
        IRepository<Partner, long> _partnerRepo { get; }
        IRepository<Warehouse, long> _warehouseRepo { get; }
        IRepository<Transaction, long> _transactionRepo { get; }
        IRepository<TransactionLine, long> _transactionLineRepo { get; }
        IRepository<Bin, long> _binRepo { get; }
        Task<bool> Complete();

    }
}
