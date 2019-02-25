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
    public class CategoriaController : BaseController
    {
        private readonly ICategoriaService categoriaService;
        // GET: Categoria
        public CategoriaController(ICategoriaService pCategoriaServices)
        {
            categoriaService = pCategoriaServices;
        }
        public ActionResult Index()
        {
            //var model = categoriaService.GetAll("");
            return View();
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        //[HttpPost]
        ////public ActionResult Create(string nombre, string descripcion)
        //public ActionResult Create(Categoria model)
        //{
        //    var result = categoriaService.Save(model);
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        //public ActionResult Create(string nombre, string descripcion)
        public ActionResult Create([ModelBinder(binderType:typeof(CategoriaBinder))] Categoria model)
        {
            bool result = categoriaService.Save(model);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Categoria model = categoriaService.GetById(id);
            return View("Create", model);
        }

        [HttpPost]
        public ActionResult Edit(Categoria model)
        {
            bool result = categoriaService.Save(model);
            //var result = categoriaService.Save(model);
            return RedirectToAction("Index");
        }

        public ActionResult Buscar(string filtroPorNombre)
        {
            filtroPorNombre = filtroPorNombre != null ? filtroPorNombre : "";
            var model = categoriaService.GetAll(filtroPorNombre);
            return PartialView("IndexListado", model);
        }
    }
}