using Dankos.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dankos.Web.Controllers
{
    public class BarangController : Controller
    {
        // GET: Barang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tampil()
        {
            return Json(BarangRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }
    }
}