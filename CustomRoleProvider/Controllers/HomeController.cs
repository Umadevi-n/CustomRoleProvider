using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomRoleProvider.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "user,Admin")]
        public ActionResult UserArea()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]

        public ActionResult AdminArea()
        {
            return View();
        }



    }
}