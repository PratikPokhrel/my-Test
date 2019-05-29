using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTest.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? EndDate { get; set; }          
        public bool IsComplete { get; set; }
        public bool Status { get; set; }
    }
}
