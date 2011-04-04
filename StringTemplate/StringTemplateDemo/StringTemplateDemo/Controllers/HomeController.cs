using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StringTemplateDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

		public ActionResult HelloWorld()
		{
			ViewData["HelloWorld"] = "Hello World";
			ViewData["HelloWorldHtml"] = Server.HtmlEncode("<h1>Hello World</h1>");

			return View();
		}
		public ActionResult Condition()
		{
			if (DateTime.Today == new DateTime(2011, 4, 1))
				ViewData["SdcDay"] = true;
			else
				ViewData["SdcDay"] = false;
			
			return View();
		}

		public ActionResult Loops()
		{
			ViewData["Values"] = new[] {"One", "Two", "Three"};
			return View();
		}

		public ActionResult Layout()
		{			
			return View();

		}

		public ActionResult Partials()
		{
			return View();

		}

    }
}
