using AspNetMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.DAL.Interfaces
{
    public interface ICourseRepository
    {
        int Create(Course entity);
        int Delete(Course entity);
        IQueryable<Course> GetAll();
        Course GetById(int id);
    }
}
