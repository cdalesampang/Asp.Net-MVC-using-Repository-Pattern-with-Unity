﻿using AspNetMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Web.Models
{
    public class StudentAddVM
    {
        public Student Student { get; set; }
        public IEnumerable<SelectListItem> Courses { get; set; }
    }
}