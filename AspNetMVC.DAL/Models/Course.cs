using AspNetMVC.DAL.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.DAL.Models
{
    public class Course : BaseClass
    {
        public string Description { get; set; }
        public string Code { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
