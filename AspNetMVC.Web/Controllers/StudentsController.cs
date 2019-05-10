using AspNetMVC.BAL.Interfaces;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Web.Controllers
{
    public class StudentsController : Controller
    {
        int pageSize = 10;
        private IStudentService studentService;
        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        // GET: Student
        public ActionResult Index(int page = 1)
        {
            var students = studentService.GetAll();

            return View(students.ToPagedList(page,pageSize));
        }
    }
}