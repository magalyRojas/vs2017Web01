using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.UI.Web.MVC.Controllers.Movimientos
{
    public class VentaController : BaseController
    {
        // GET: Venta
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Guardar(Venta model)
        {
            var result = true;

            //acceder a la capa de negocio y de datos
            //para registrar la venta

            return Json(result);
        }
    }
}