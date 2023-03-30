using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Pass_Session_MVC.Models;

namespace Pass_Session_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<SelectListItem> ObjItem = new List<SelectListItem>()
            {
          new SelectListItem {Text="Select",Value="0",Selected=true },
          new SelectListItem {Text="ASP.NET",Value="1" },
          new SelectListItem {Text="C#",Value="2"},
          new SelectListItem {Text="MVC",Value="3"},
          new SelectListItem {Text="SQL",Value="4" },
            };
            ViewBag.ListItem = ObjItem;
            return View();
        }

        [HttpPost]
        public ActionResult Send()
        {
          //  sessionStorage.setItem('sessionObject', JSON.stringify(sessionObject));

            //Send Model object as Session to another Controller.
            return RedirectToAction("Index", "PersonDetails");
        }

        [HttpPost]
        public ActionResult saveproduct(string area, string branch, string datepick,string edatepick,string timer1,string timer2,string quantity,string productname,string silo,string notes)
        
        {
            List<ProductModel> pm = new List<ProductModel>();
            
            ProductModel PS = new ProductModel();
            if (Session["Person"] == null)
            {
                PS.timer1 = timer1;
                PS.timer2 = timer2;
                PS.area = area;
                PS.branch = branch;
                PS.datepick = datepick;
                PS.edatepick = edatepick;
                PS.quantity = quantity;
                PS.productname = productname;
                PS.silo = silo;
                PS.notes = notes;
                pm.Add(PS);
                Session["Person"] = pm;
            }
            else
            {
                pm = (List<ProductModel>)Session["Person"];
                PS.timer1 = timer1;
                PS.timer2 = timer2;
                PS.area = area;
                PS.branch = branch;
                PS.datepick = datepick;
                PS.edatepick = edatepick;
                PS.quantity = quantity;
                PS.productname = productname;
                PS.silo = silo;
                PS.notes = notes;
                pm.Add(PS); 
                Session["Person"] = pm;
            }
             return View(pm);
        }
    }
}