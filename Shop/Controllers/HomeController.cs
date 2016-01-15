using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private ItemContext db = new ItemContext();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/Computers

        public ActionResult Computers()
        {
            return View(db.Comp.ToList());
        
        }
        public ActionResult Computers2()
        {
            return View(db.Comp.ToList());
        }
	}
}