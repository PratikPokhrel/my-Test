using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Models;
using RepositoryAndUnitOfWork.Repositories;

namespace MyTest.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly TodoContext _customerDbEntities;

        public StudentRepository(TodoContext context) : base(context)
        {
            _customerDbEntities = context;
        }

        public  IEnumerable<Student> GetAllStudents()
        {
            return  _customerDbEntities.Students.OrderByDescending(x => x.Name).Include(x => x.Courses).ToList();
        }
    }
}
