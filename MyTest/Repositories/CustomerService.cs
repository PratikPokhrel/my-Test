using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Models;
using RepositoryAndUnitOfWork.DataAccess.Repositories;

namespace MyTest.Repositories
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _uow;
        public CustomerService(IUnitOfWork unit)
        {
            _uow = unit;
        }
        public IEnumerable<TodoItem> GetBestCustomers()
        {
          return _uow.Customers.GetBestCustomers(1).ToList();
        }
       
    }
}
