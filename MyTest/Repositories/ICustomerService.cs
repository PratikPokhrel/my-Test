using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Models;

namespace MyTest.Repositories
{
    public interface ICustomerService
    {
         IEnumerable<TodoItem> GetBestCustomers();
    }
}
