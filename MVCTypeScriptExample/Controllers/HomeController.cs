using MVCTypeScriptExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTypeScriptExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetUsers()
        {
            List<User> users = new List<User> 
            { 
                new User {Id=1, Name="Tom", Age=23},
                new User {Id=2, Name="Alice", Age=28},
                new User {Id=3, Name="Bill", Age=32}
            };

            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}