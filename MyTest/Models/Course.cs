using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace MyTest.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public  virtual  Student Student { get; set; }
    }
}
