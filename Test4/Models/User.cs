using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test4.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public bool Married { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
