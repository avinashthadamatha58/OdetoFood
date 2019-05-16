using OdetoFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdetoFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //[Authorize]
        [Log]
        public ActionResult Search(string name = "french")
        {
            throw new Exception("Something terrible happened");
            var message = Server.HtmlEncode(name);
           // return Content(message);
            return Content(message);
        }
    }
}