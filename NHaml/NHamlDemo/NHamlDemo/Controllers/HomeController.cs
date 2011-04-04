/*
 * This sample is a part of the session "The Big Comparison of ASP.NET MVC View Engines"
 * Written by Shay Friedman (http://ironshay.com)
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHamlDemo.Controllers
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
			return View();
		}
		public ActionResult Loops()
		{
			return View();
		}
		public ActionResult DisplayingAForm()
		{
			return View();
		}
		public ActionResult Layouts()
		{
			return View();
		}
		public ActionResult Dry()
		{
			return View();
		}

	}
}
