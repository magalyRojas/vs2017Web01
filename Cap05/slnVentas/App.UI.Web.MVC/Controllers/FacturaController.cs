using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.UI.Web.MVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class FacturaController : BaseController
    {

        public ActionResult Create()
        {
            return View();
        }
        // GET: Factura
        public ActionResult Index()
        {
            return View();
        }
    }
}