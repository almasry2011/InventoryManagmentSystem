using InventoryManagement.Domain.Enum;
 
using InventoryManagement.Persistence.UnitOfWork;
using InventoryManagement.Service.Contract;
using InventoryManagement.Service.Dto.Dashboard;
using InventoryManagement.Service.Exceptions;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace InventoryManagement.Service.Implementation
{


    public class DashboardService : IDashboardService
 
    {
        private readonly IUnitOfWork<ProductService, long> _uow;

        public DashboardService(IUnitOfWork<ProductService, long> uow)
        {
            _uow = uow;
        }
        public DashboardModelDto GetDashboardData ()
        { 
            try
            {

             
                    var lastFriday = GetFriday().lastFriday;
                    var NextFriday = GetFriday().nextFriday;

                //DateTime lastWednesday = DateTime.Now.AddDays(-1);
                //while (lastWednesday.DayOfWeek != DayOfWeek.Friday)
                //    lastWednesday = lastWednesday.AddDays(-1);




                var model = new DashboardModelDto
                {
                    Products = _uow._productRepo.GetAll().Count(),
                    Purchase = _uow._transactionRepo.GetAll(s => s.TransactionType == TransactionType.Purchase).Sum(s => s.Total),
                    Sales = _uow._transactionRepo.GetAll(s => s.TransactionType == TransactionType.Sales).Sum(s => s.Total),

                    LWPurchase = _uow._transactionRepo.GetAll(s=> LastWeekPurchaseCraiteria(s)).Sum(s => s.Total),

                    //_uow._transactionRepo.GetAll(s => s.TransactionType == TransactionType.Purchase
                    //&& s.TransactionDate >= lastFriday && s.TransactionDate <= NextFriday).Sum(s => s.Total),

                    LWSales = _uow._transactionRepo.GetAll(s => s.TransactionType == TransactionType.Sales
                     && s.TransactionDate >= lastFriday && s.TransactionDate <= NextFriday).Sum(s => s.Total),

                    LWDate = $" LastFriday = ${lastFriday} -- NextFriday = ${NextFriday}  "

                };
                return model;
            }
            catch (System.Exception ex)
            {

                throw new ApiException(ex.Message);
            }
        }


        private (DateTime lastFriday, DateTime nextFriday) GetFriday()
        {

            DateTime nextFriday = DateTime.Now.AddDays(1);
            while (nextFriday.DayOfWeek != DayOfWeek.Friday)
                nextFriday = nextFriday.AddDays(1);


            DateTime lastFriday = DateTime.Now.AddDays(-1);
            while (lastFriday.DayOfWeek != DayOfWeek.Friday)
                lastFriday = lastFriday.AddDays(-1);

            return (lastFriday, nextFriday);

        }


      //  Func<Employee, bool> isNewAndSurvived = e => isActiveEmployee(e) && isNewEmployee(e);

        Func<Transaction, bool> LastWeekPurchaseCraiteria( )
        {
          

            return x => x.
            
            //x % n == 0;
        }








    }
}