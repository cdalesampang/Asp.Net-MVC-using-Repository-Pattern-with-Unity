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
        bool Create(Student entity, IEnumerable<string> courses);
        IEnumerable<Student> GetAll();
        Student GetById(int id);
    }
}
