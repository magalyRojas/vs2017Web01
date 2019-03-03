using App.Domain.Services.Interfaces;
using App.UI.Web.MVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.UI.Web.MVC.Areas.AdminSeguridad.Controllers
{
    public class HomeController : BaseController
    {
        //inyectar
        private readonly ISeguridadService seguridadService;

        // construyendo controlador
        public HomeController(ISeguridadService pSeguridadService)
        {
            seguridadService = pSeguridadService;
        }

        // GET: Seguridad/Home
        public ActionResult Index()
        {
            var model = seguridadService.GetAll("");

            return View(model);
        }

        public ActionResult Buscar(string filtroPorNombre)
        {
            filtroPorNombre = filtroPorNombre != null ? filtroPorNombre : "";
            var model = seguridadService.GetAll(filtroPorNombre);
            return PartialView("IndexListado", model);
        }
    }
}