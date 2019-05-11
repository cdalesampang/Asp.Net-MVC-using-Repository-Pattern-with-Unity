using AspNetMVC.DAL.Interfaces;
using AspNetMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.DAL.Repositories
{
    public class StudentCourseRepository : IStudentCourseRepository
    {
        private ApplicationDbContext dbContext;

        public StudentCourseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public int Create(int courseId, int studentId)
        {
            var entity = new StudentCourse()
            {
                CourseId = courseId,
                StudentId = studentId
            };

            dbContext.StudentCourses.Add(entity);

            return dbContext.SaveChanges();
        }


        public int Delete(IEnumerable<StudentCourse> entities)
        {
            dbContext.StudentCourses.RemoveRange(entities);
            return dbContext.SaveChanges();
        }

        public IQueryable<StudentCourse> GetAll()
        {
            return dbContext.StudentCourses.AsQueryable();
        }

        public IQueryable<Course> GetAllByStudentId(int id)
        {
            return dbContext.StudentCourses.Where(x => x.StudentId == id).Select(x => x.Course).AsQueryable();
        }

        public IQueryable<Student> GetAllByCourseId(int id)
        {
            return dbContext.StudentCourses.Where(x => x.CourseId == id).Select(x => x.Student).AsQueryable();
        }


    }
}
