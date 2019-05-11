using AspNetMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.DAL.Interfaces
{
    public interface IStudentRepository
    {
        int Create(Student entity);
        IQueryable<Student> GetAll();
        Student GetById(int id);
    }
}
