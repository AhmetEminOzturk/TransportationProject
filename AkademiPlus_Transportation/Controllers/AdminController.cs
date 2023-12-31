﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        
        public ActionResult Index()
        {
            ViewBag.productCount = db.TblProduct.Count();
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.customerCount = db.TblCustomer.Count();
            ViewBag.employeeCount = db.TblEmployee.Count();
            var values = Session["UserName"];
            ViewBag.username = values;
            return View();
        }
    }
}