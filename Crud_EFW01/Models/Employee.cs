using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_EFW01.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
    }
}