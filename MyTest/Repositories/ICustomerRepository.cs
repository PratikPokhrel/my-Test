using System.Collections.Generic;
using MyTest.Models;

namespace RepositoryAndUnitOfWork.DataAccess.Repositories
{
    public interface ICustomerRepository : IRepository<TodoItem>
    {
        IEnumerable<TodoItem> GetBestCustomers(int amountOfCustomers);
    }
}