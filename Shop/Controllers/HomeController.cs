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
            return View(); //db.Comp.ToList()
        
        }
        public ActionResult Computers2()
        {
            return View(db.Comp.ToList());
        }

        [HttpPost]
        public ActionResult Computers(string id)
        {
            // id - имя клиента, заказы которого необходимо выводить на странице.
            return View("Computers", (object)id);
        }

        public ActionResult OrdersData(string id)
        {
            var data = db.Comp.ToList();
            if (!string.IsNullOrEmpty(id) && id != "All")
            {
                // выполняем выборку по свойству Customer если значение id не пустое и не равное "All"
                data = data.Where(e => e.Firm == id).ToList();
            }
            return PartialView(data);
        }
	}
}