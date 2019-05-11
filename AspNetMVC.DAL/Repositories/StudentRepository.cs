using AspNetMVC.DAL.Interfaces;
using AspNetMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.DAL.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private ApplicationDbContext dbContext;
        public StudentRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int Create(Student entity)
        {
            entity.DateCreated = DateTime.Now;
            dbContext.Students.Add(entity);

            return dbContext.SaveChanges();
        }

        public IQueryable<Student> GetAll()
        {
            return dbContext.Students.Include("StudentCourses").AsQueryable();
        }

        public Student GetById(int id)
        {
            return dbContext.Students.Include("StudentCourses").FirstOrDefault(x => x.Id == id);
        }
    }
}
