﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zelda.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			ViewBag.Title = "Zelda";

			return View();
		}
	}
}
