using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeightLoss.Controllers
{                   
    public class CuisineController : Controller
    {
      [Authorize]
        public ActionResult Search(string name = "Polish")
        {
            var message = Server.HtmlEncode(name);
                return Content(message);
        }

        //public ActionResult Search()
        //{
         
        //    return Content("XaXa");
        //}

    }
}