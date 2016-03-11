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
            HttpCookie myCookie = new HttpCookie("UserSettings");
            myCookie["Font"] = "Arial";
            myCookie["Color"] = "Blue";
            myCookie.Expires = DateTime.Now.AddDays(1d);
            Response.Cookies.Add(myCookie);
            PopulateDepartmentsDropDownList();
            return View();
        }

        private void PopulateDepartmentsDropDownList(object selectedDepartment = null)
        {
            var data = db.Comp.ToList();

            //Ну а собственно следущая строка и является модификацией этого метода, изначально описанного в примере Contoso University
            //NewsMID = 0 -  это и есть value
            //Title = "Add to root" - text
            // departmentsQuery.Add(new NewsM { NewsMID = 0, Title = "Add to root" });
            var phones = db.Comp.Select(p => p.Firm);
            ViewBag.ParentID = new SelectList(phones);
        }
        //private void PopulateDepartmentsDropDownList()
        //{

            //    var data = db.Comp.ToList();
            //    //if (!string.IsNullOrEmpty(id) && id != "All")
            //    //{
            //    //    // выполняем выборку по свойству Customer если значение id не пустое и не равное "All"
            //    //    data = data.Where(e => e.Firm == id).ToList();
            //    //}
            //    //var departmentsQuery = from d in data.Firm
            //    //                       orderby d.Name
            //    //                       select d;
            //        var phones = db.Comp.Select(p => p.Firm); 
            //    ViewBag.DepartmentID = new SelectList(phones);
            //}

        public ActionResult Computers3()
        {
            return View();

        }
        public ActionResult OrdersData3() //List<Computers> data
        {
           // var mas =db.Comp.ToList();
            var data = db.Comp.ToList();
            List<string> list = new List<string>();
            foreach (var item in data)
            {
                if (Request.Form[item.Firm] != null && Request.Form[item.Firm] == "true,false")
                {
                    list.Add( item.Firm.ToString());
                }
            }
            if (list.Count > 0)
            {
                data =  data.Where(e => list.Contains(e.Firm)).ToList();
            }
            return PartialView(data);
        }
        public ActionResult NavigatMenu3()
        {
            var data = db.Comp.ToList(); //.Select(e => e.Firm)
            OrdersData3();
            return PartialView(data);
        }
        //[HttpPost]
        //public ActionResult NavigatMenu3( string id)
        //{
        //    var data = db.Comp.ToList();
        //    OrdersData3();
        //    return PartialView(data);
        //}
        public ActionResult ComputersWebGrid()
        {

            var phones = db.Comp.Select(p => p.Firm);
            //  ViewBag.ApplyDiscount;
            //   ViewBag.ApplyDiscount = ViewData.Computers2.checbox1;
            //ViewBag.ApplyDiscount = Request.Form["checbox1"];
            ViewBag.Parent = "нееет";
            ViewBag.ParentID = new SelectList(phones);//new SelectList("all",phones);
            return View(db.Comp.ToList());
        }
        public ActionResult Computers2()
        {
            
            var phones = db.Comp.Select(p => p.Firm);
          //  ViewBag.ApplyDiscount;
         //   ViewBag.ApplyDiscount = ViewData.Computers2.checbox1;
            //ViewBag.ApplyDiscount = Request.Form["checbox1"];
            ViewBag.Parent = "нееет";
            ViewBag.ParentID = new SelectList(phones );//new SelectList("all",phones);
            return View(db.Comp.ToList());
        }

        [HttpPost]
        public ActionResult Computers2(string mycheck, string message, string ParentID)
        {
            string userSettings="";
            var dfd = Request.Form["mycheck"] != null && Request.Form["mycheck"] == "true,false";
            if (Request.Form["mycheck"] != null && Convert.ToBoolean(mycheck))
            {
                if (Request.Cookies["UserSettings"] != null)
                {
                   
                    if (Request.Cookies["UserSettings"]["Font"] != null)
                    { userSettings = Request.Cookies["UserSettings"]["Font"]; }
                }
                ViewBag.Parent = userSettings;//"да, да, да";
            }
           // ViewBag.Parent = Request.Form["mycheck"];
            ViewBag.Message = message;
            
            var data = db.Comp.ToList();

            if (!string.IsNullOrEmpty(ParentID) && ParentID != "All")
            {
                // выполняем выборку по свойству Customer если значение id не пустое и не равное "All"
                data = data.Where(e => e.Firm == ParentID).ToList();
            }
            // id - имя клиента, заказы которого необходимо выводить на странице.
            var phones = db.Comp.Select(p => p.Firm);

            ViewBag.ParentID = new SelectList(phones);//new SelectList("all",phones);
            return View(data);
        }
        //[HttpPost]
        //public ActionResult Comput(string mycheck)
        //{
        //    if (Request.Form["mycheck"] != null && Convert.ToBoolean(mycheck))
        //    {
        //        ViewBag.Parent = "да, да, да";
        //    }
        //    var phones = db.Comp.Select(p => p.Firm);
        //    var data = db.Comp.ToList();
        //    ViewBag.ParentID = new SelectList(phones);//new SelectList("all",phones);
        //    return RedirectToAction("Computers2", "Home");
        //}

        //
        // GET: /Home/Computers

        public ActionResult Computers()
        {
            return View(); //db.Comp.ToList()

        }

        //[HttpPost]
        //public ActionResult Computers(string id)
        //{
        //    // id - имя клиента, заказы которого необходимо выводить на странице.
        //    return View("Computers", (object)id);
        //}

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
        protected override void Dispose(bool disposing)

        {

            if (disposing)

                db.Dispose();

            base.Dispose(disposing);

        }
    }
}