using AspNetMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.BAL.Interfaces
{
    public interface IStudentService
    {
        bool Create(Student entity);
        bool Delete(int id);
        IEnumerable<Student> GetAll();
        Student GetById(int id);
    }
}
