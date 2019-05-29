using System;
using MyTest.Repositories;

namespace RepositoryAndUnitOfWork.DataAccess.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IStudentRepository Students  { get; }


        int Complete();
    }
}