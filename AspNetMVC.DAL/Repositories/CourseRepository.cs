using AspNetMVC.DAL.Interfaces;
using AspNetMVC.DAL.Models;
using AspNetMVC.DAL.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.DAL.Repositories
{
    public class CourseRepository: ICourseRepository
    {
        private ApplicationDbContext dbContext;
        public CourseRepository(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public int Create(Course entity)
        {
            dbContext.Courses.Add(entity);

            return dbContext.SaveChanges();
        }

        public IQueryable<Course> GetAll()
        {
            return dbContext.Courses.AsQueryable();
        }

        public Course GetById(int id)
        {
            return dbContext.Courses.FirstOrDefault(x => x.Id == id);
        }
    }
}
