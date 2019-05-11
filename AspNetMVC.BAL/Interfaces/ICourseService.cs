using AspNetMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.BAL.Interfaces
{
    public interface ICourseService 
    {
        bool Create(string code, string description);
        IEnumerable<Course> GetAll();
        IEnumerable<Student> GetAllStudent(int courseId);
        IEnumerable<Course> GetAll(int pageSize, int pageNumber = 1);
        Course GetById(int id);
    }
}
