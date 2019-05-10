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
        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
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

        public bool Delete(int id)
        {
            var entity = courseRepository.GetById(id);
            if (entity != null)
                return courseRepository.Delete(entity) > 0 ? true : false;

            return false;

        }

        public IEnumerable<Course> GetAll()
        {
            return courseRepository.GetAll().ToList();
        }

        public IEnumerable<Course> GetAll(int pageSize, int pageNumber = 1)
        {
            return courseRepository.GetAll().Skip(pageNumber-1).Take(pageSize).ToList();
        }

        public Course GetById(int id)
        {
            return courseRepository.GetById(id);
        }
    }
}
