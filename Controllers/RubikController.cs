using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenTienDat.Models;

namespace NguyenTienDat.Controllers
{
    public class RubikController : Controller
    {
        // GET: Rubik
        RubikStoreContext data = new RubikStoreContext();
        public ActionResult Index()
        {
            var all_rubik = from s in data.Rubiks select s;
            return View(all_rubik);
        }
    }
}