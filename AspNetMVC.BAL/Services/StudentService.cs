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
    public class StudentService : IStudentService
    {
        private IStudentRepository studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public bool Create(Student entity)
        {
            return studentRepository.Create(entity) > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            var entity = studentRepository.GetById(id);
            if (entity != null)
                return studentRepository.Delete(entity) > 0 ? true : false;

            return false;
        }

        public IEnumerable<Student> GetAll()
        {
            return studentRepository.GetAll().ToList();
        }

        public Student GetById(int id)
        {
            return studentRepository.GetById(id);
        }
    }
}
