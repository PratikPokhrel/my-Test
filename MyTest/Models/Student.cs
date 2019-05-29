using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTest.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public  virtual  ICollection<Course> Courses { get; set; }
    }
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public int TotalCourse { get; set; }
    }

    public class BloggerDtosProfile : AutoMapper.Profile
    {
        public BloggerDtosProfile()
        {
            CreateMap<Student, StudentDto>();
            // Add other CreateMap’s for any other configs
        }
    }

}
