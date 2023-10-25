using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class MainPageController : Controller
    {
        
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialDetail()
        {
            ViewBag.LeftTitle1 = "Güvenli Taşımacılık";
            ViewBag.LeftTitle2 = "Dünyanın Her Yerine Tüm Kargo";
            ViewBag.LeftTitle3 = "Konumu fark etmeksizin, doğudan batıya, kuzeyden güneye en uzak noktalara uzman ekibimizle güvenli teslimat yapıyoruz.";
            
            ViewBag.RightTitle1 = "Taşıma Kolaylığı";
            ViewBag.RightTitle2 = "Kendi ambalajlarımız ile kargolarınızı paketliyoruz.";
            
            ViewBag.RightTitle3 = "Şehir İçi Dağıtım";
            ViewBag.RightTitle4 = "İstediğiniz saatte evlerinize veya belirlediğiniz yerlere teslimat yapmaktayız.";

           return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialMap()
        {
            return PartialView();
        }

    }
}