using App.Domain.Services;
using App.Domain.Services.Interfaces;
using App.Entities.Base;
using App.UI.Web.MVC.ModelBinders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.UI.Web.MVC.Controllers.Mantenimientos
{
    [Authorize(Roles = "Admin")]
    public class ClienteController : BaseController
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService pClienteService)
        {
            clienteService = pClienteService;
        }


        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create([ModelBinder(binderType: typeof(ClienteBinder))] Cliente model)
        {
            bool result = clienteService.Save(model);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Cliente model = clienteService.GetById(id);
            return View("Create", model);
        }
        
        [HttpPost]
        public ActionResult Edit(Cliente model)
        {
            bool result = clienteService.Save(model);
            return RedirectToAction("Index");
        }

        public ActionResult Buscar(string filtroPorNombre)
        {
            filtroPorNombre = filtroPorNombre != null ? filtroPorNombre : "";
            var model = clienteService.GetAll(filtroPorNombre);
            return PartialView("IndexListado", model);
        }

    }
}