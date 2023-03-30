using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pass_Session_MVC.Models;
 
namespace Pass_Session_MVC.Controllers
{
    public class PersonDetailsController : Controller
    {
        // GET: PersonDetails
        public ActionResult Index()
        {
            ProductModel person = (ProductModel)Session["Person"];
            return View(person);
        }
    }
}