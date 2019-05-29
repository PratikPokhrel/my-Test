using MyTest.Models;
using MyTest.Repositories;
using RepositoryAndUnitOfWork.DataAccess;
using RepositoryAndUnitOfWork.DataAccess.Repositories;

namespace RepositoryAndUnitOfWork.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TodoContext _context;

        public UnitOfWork(TodoContext context)
        {
            _context = context;
            Customers = new CustomerRepository(_context);
            Students = new StudentRepository(_context);

        }

        public ICustomerRepository Customers { get; }
        public IStudentRepository Students { get; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}