using AspNetMVC.BAL.Interfaces;
using AspNetMVC.DAL.Models;
using AspNetMVC.Web.Constant;
using AspNetMVC.Web.Helper;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Web.Controllers
{
    public class CourseController : Controller
    {
        int pageSize = 10;
        private ICourseService courseService;
        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }


  
        public ActionResult Index(int page = 1)
        {
            IEnumerable<Course> courses = courseService.GetAll();

            return View(courses.ToPagedList(page, pageSize));
        }

        [HttpPost]
        public ActionResult Course(string code, string description)
        {
            if (String.IsNullOrEmpty(code) || String.IsNullOrEmpty(description))
            {
                Notification.SendNotification(this,"All fields are required!", (int)NotificationEnum.error);
                return RedirectToAction("Index", "Course");
            }
            else
            {
                bool result = courseService.Create(code, description);
                if (result)
                {
                    Notification.SendNotification(this,"Course Successfully Added!", (int)NotificationEnum.success);
                    return RedirectToAction("Index", "Course");
                }
                else
                {
                    Notification.SendNotification(this,"Course not added!", (int)NotificationEnum.error);
                    return RedirectToAction("Index", "Course");
                }

            }
        }

        public ActionResult Students(int id, int page = 1)
        {
            var students = courseService.GetAllStudent(id);

            return View(students.ToPagedList(page,pageSize));
        }


    }
}