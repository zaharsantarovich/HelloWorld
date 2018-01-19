using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			// Implemented feature Admin-001.
			// Fixed critical bug Admin-006.
			return View();
		}

		public ActionResult About()
		{
			// Implemented feauture Admin-002.
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			// Fixed critical bug Admin-003.
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}