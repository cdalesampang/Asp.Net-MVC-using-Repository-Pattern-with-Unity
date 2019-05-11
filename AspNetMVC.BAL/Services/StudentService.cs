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
        private IStudentCourseRepository studentCourseRepository;
        public StudentService(IStudentRepository studentRepository,
             IStudentCourseRepository studentCourseRepository)
        {
            this.studentRepository = studentRepository;
            this.studentCourseRepository = studentCourseRepository;
        }

        public bool Create(Student entity, IEnumerable<string> courses)
        {
            if (studentRepository.Create(entity) > 0)
            {
                foreach (var item in courses)
                {
                    this.studentCourseRepository.Create(Convert.ToInt32(item), entity.Id);
                }
                return true;
            }
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
