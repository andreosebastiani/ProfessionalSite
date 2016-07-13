using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndreoSebastiani.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult TestException()
        {
            try
            {
                throw new Exception("An Inner exception has been thrown.");
            }
            catch (Exception e)
            {
                throw new Exception("An exception has been thrown.", e);
            }
        }
    }
}