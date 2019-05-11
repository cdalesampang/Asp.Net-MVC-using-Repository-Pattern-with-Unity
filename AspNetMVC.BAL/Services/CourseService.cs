using AspNetMVC.BAL.Interfaces;
using AspNetMVC.DAL.Interfaces;
using AspNetMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.BAL.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository courseRepository;
        private IStudentCourseRepository studentCourseRepository;
        public CourseService(ICourseRepository courseRepository,
            IStudentCourseRepository studentCourseRepository)
        {
            this.courseRepository = courseRepository;
            this.studentCourseRepository = studentCourseRepository;
        }

        public bool Create(string code, string description)
        {
            Course entity = new Course()
            {
                Code = code,
                Description = description,
                DateCreated = DateTime.Now
            };
            return courseRepository.Create(entity) > 0 ? true : false;
        }

        public IEnumerable<Course> GetAll()
        {
            return courseRepository.GetAll().ToList();
        }

        public IEnumerable<Course> GetAll(int pageSize, int pageNumber = 1)
        {
            return courseRepository.GetAll().Skip(pageNumber-1).Take(pageSize).ToList();
        }

        public IEnumerable<Student> GetAllStudent(int courseId)
        {
            return studentCourseRepository.GetAllByCourseId(courseId).ToList();
        }

        public Course GetById(int id)
        {
            return courseRepository.GetById(id);
        }
    }
}
