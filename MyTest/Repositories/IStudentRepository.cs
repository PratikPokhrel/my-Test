using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Models;
using RepositoryAndUnitOfWork.DataAccess.Repositories;

namespace MyTest.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
     IEnumerable<Student> GetAllStudents();
    }
}
