using AspNetMVC.BAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using AspNetMVC.DAL.Models;
using AspNetMVC.Web.Constant;

namespace AspNetMVC.Web.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }
        
    }
}