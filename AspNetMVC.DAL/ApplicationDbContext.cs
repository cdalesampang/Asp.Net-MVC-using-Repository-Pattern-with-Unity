using AspNetMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("StudentConnection")
        {
        }


        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(q =>
            new
            {
                q.StudentId,
                q.CourseId
            });
           
                

           
            base.OnModelCreating(modelBuilder);
        }

    }
}
