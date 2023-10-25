using AkademiPlus_Transportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace AkademiPlus_Transportation.Controllers
{
    public class ProductController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            ViewBag.productCount = db.TblProduct.Count();
            var values = db.TblProduct.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in db.TblCategory
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString(),
                                           }).ToList();
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(TblProduct tblProduct)
        {
            db.TblProduct.Add(tblProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var value = db.TblProduct.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProduct(TblProduct tblProduct)
        {
            var value = db.TblProduct.Find(tblProduct.ProductID);
            value.ProductName = tblProduct.ProductName;
            value.ProductSize = tblProduct.ProductSize;
            value.ProductSizeType = tblProduct.ProductSizeType;
            value.ProductDescription = tblProduct.ProductDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}