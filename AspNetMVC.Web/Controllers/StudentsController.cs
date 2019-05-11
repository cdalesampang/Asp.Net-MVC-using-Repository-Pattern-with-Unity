using AspNetMVC.BAL.Interfaces;
using AspNetMVC.DAL.Models;
using AspNetMVC.Web.Constant;
using AspNetMVC.Web.Helper;
using AspNetMVC.Web.Models;
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
        private ICourseService courseService;
        public StudentsController(IStudentService studentService,
            ICourseService courseService)
        {
            this.studentService = studentService;
            this.courseService = courseService;
        }

        public ActionResult Add()
        {
            var model = new StudentAddVM();
            model.Courses = courseService.GetAll().Select(x => new SelectListItem() {
                Text = x.Code,
                Value = x.Id.ToString()
            });
            return View(model);
        }

        // GET: Student
        public ActionResult Index(int page = 1)
        {
            var students = studentService.GetAll();
            return View(students.ToPagedList(page,pageSize));
        }


        [HttpPost]
        public ActionResult Add(Student student, List<string> courses)
        {
            if (ModelState.IsValid)
            {
                var result = studentService.Create(student, courses);
                if (result)
                {
                    Notification.SendNotification(this, "Student Succesfully Added", (int)NotificationEnum.success);
                }
            }
            return RedirectToAction("Index");
        }
        

    }
}