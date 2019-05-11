using AspNetMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.DAL.Interfaces
{
    public interface IStudentCourseRepository
    {
        int Create(int courseId,int studentId);
        IQueryable<StudentCourse> GetAll();
        IQueryable<Student> GetAllByCourseId(int id);
        IQueryable<Course> GetAllByStudentId(int id);
    }
}
