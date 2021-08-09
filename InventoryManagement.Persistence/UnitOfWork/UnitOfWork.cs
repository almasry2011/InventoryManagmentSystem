using InventoryManagement.Domain;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Persistence.UnitOfWork
{
    public class UnitOfWork<T, PK> : IUnitOfWork<T, PK> where T : class
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IRepository<T, PK> Repository => new Repository<T, PK>(_context);


        public IRepository<Product, long> _productRepo => new Repository<Product, long>(_context);

        public IRepository<Category, long> _categoryRepo => new Repository<Category, long>(_context);

        public IRepository<Partner, long> _partnerRepo => new Repository<Partner, long>(_context);

        public IRepository<Warehouse, long> _warehouseRepo => new Repository<Warehouse, long>(_context);


        public IRepository<Transaction, long> _transactionRepo => new Repository<Transaction, long>(_context);

        public IRepository<TransactionLine, long> _transactionLineRepo => new Repository<TransactionLine, long>(_context);

        public IRepository<Bin, long> _binRepo => new Repository<Bin, long>(_context);

        public IRepository<ProductDetails, long> _productDetailsRepo => new Repository<ProductDetails, long>(_context);

        public async Task<bool> Complete()
        {
            try
            {
                if (await _context.SaveChangesAsync() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
