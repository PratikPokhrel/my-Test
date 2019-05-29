using System;
using System.Collections.Generic;
using System.Linq;
using MyTest.Models;
using RepositoryAndUnitOfWork.DataAccess;
using RepositoryAndUnitOfWork.DataAccess.Repositories;

namespace RepositoryAndUnitOfWork.Repositories
{
    public class CustomerRepository : Repository<TodoItem>, ICustomerRepository
    {
        private readonly TodoContext _customerDbEntities;

        public CustomerRepository(TodoContext context) : base(context)
        {
            _customerDbEntities = context;
        }

        public IEnumerable<TodoItem> GetBestCustomers(int amountOfCustomers)
        {
            if (amountOfCustomers > _customerDbEntities.TodoItems.ToList().Count)
            {
                throw new IndexOutOfRangeException();
            }
            return _customerDbEntities.TodoItems.OrderByDescending(x => x.Name).Take(amountOfCustomers).ToList();
        }
    }
}