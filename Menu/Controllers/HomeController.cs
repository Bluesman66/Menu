using Menu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Menu.Controllers
{
	public class HomeController : Controller
	{
		ApplicationContext db = new ApplicationContext();

		public ActionResult Index()
		{
			return View();
		}	

		public ActionResult _Menu()
		{
			List<MenuItem> menuItems = db.MenuItems.ToList();

			return PartialView("_Menu", menuItems);
		}
	}
}