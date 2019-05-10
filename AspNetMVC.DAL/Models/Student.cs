using AspNetMVC.DAL.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.DAL.Models
{
    public class Student : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }


        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
