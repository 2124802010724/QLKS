using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKS.Areas.Guest.Controllers
{
    public class GuestHomeController : Controller
    {
        //
        // GET: /Guest/GuestHome/

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

    }
}
