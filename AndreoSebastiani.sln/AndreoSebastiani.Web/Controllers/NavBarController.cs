using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndreoSebastiani.Web.Controllers
{
    public class NavBarController : Controller
    {
        public ActionResult NavBar()
        {
            return PartialView("_NavBar");
        }

        public ActionResult Footer()
        {
            return PartialView("_Footer");
        }
    }
}