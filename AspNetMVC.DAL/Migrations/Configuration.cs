namespace AspNetMVC.DAL.Migrations
{
    using AspNetMVC.DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetMVC.DAL.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AspNetMVC.DAL.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
           
            context.Courses.AddOrUpdate(new Course { Code = "BSIT", Description = "Bachelor of Science in Information Technology", DateCreated = DateTime.Now });
            context.Courses.AddOrUpdate(new Course { Code = "ACT", Description = "Associate in Computer Technology", DateCreated = DateTime.Now });

            context.Students.AddOrUpdate(new Student { FirstName = "John", LastName = "Doe", Address = "Manila", PhoneNumber = "124493", DateCreated = DateTime.Now });
            context.Students.AddOrUpdate(new Student { FirstName = "Juan", LastName = "Dela Cruz", Address = "Manila", PhoneNumber = "123493", DateCreated = DateTime.Now });

            context.StudentCourses.AddOrUpdate(new StudentCourse { CourseId = 1, StudentId = 1 });
            context.StudentCourses.AddOrUpdate(new StudentCourse { CourseId = 2, StudentId = 2 });
        }
    }
}
