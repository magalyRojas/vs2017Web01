using App.Domain.Services;
using App.Domain.Services.Interfaces;
using App.Entities.Base;
using App.UI.Web.MVC.Filters;
using App.UI.Web.MVC.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;


namespace App.UI.Web.MVC.Controllers.Mantenimientos
{
    [Authorize(Roles ="Admin")]
    [LoggingFilter]
    [HandleCustomError]
    public class ProductoController : BaseController
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly IProductoService productoService;
        private readonly ICategoriaService categoriaService;
        private readonly IMarcaService marcaService;
        private readonly IUnidadMedidaService unidadMedidaService;

        public ProductoController()
        {
            productoService = new ProductoService();
            categoriaService = new CategoriaService();
            marcaService = new MarcaService();
            unidadMedidaService = new UnidadMedidaService();
        }
        // GET: Producto
        //? soporte nulos
        public ActionResult Index(string filterByName, int? filterByCategoria, int? filterByMarca)
        {
            filterByName = string.IsNullOrWhiteSpace(filterByName) ? "" : filterByName.Trim();
            ViewBag.filterByName = filterByName;
            ViewBag.Categorias = categoriaService.GetAll("");
            ViewBag.Marcas = marcaService.GetAll("");


            var model = productoService.GetAll(filterByName, filterByCategoria, filterByMarca);
            return View(model);
        }

        public ActionResult IndexVM(ProductoSearchViewModel model)
        {
            model.Categorias = categoriaService.GetAll("").ToList();
            model.Marcas = marcaService.GetAll("").ToList();

            var filterByName = string.IsNullOrWhiteSpace(model.filterByName) ? "" : model.filterByName.Trim();

            model.Productos = productoService.GetAll(model.filterByName, model.filterByCategoria, model.filterByMarca).ToList();

            return View(model);
        }
        public ActionResult Index2(string filterByName, int? filterByCategoria, int? filterByMarca)
        {
            try
            {


                filterByName = string.IsNullOrWhiteSpace(filterByName) ? "" : filterByName.Trim();

                ViewBag.Categorias = categoriaService.GetAll("");
                ViewBag.Marcas = marcaService.GetAll("");

                //throw new Exception("Lanzando un error simulado");
                //var model = productoService.GetAll(filterByName, filterByCategoria, filterByMarca);
            }
            catch (Exception ex)
            {

                log.Error(ex);
            }
            return View();



        }

        public ActionResult Index2Buscar(string filterByName, int? filterByCategoria, int? filterByMarca)
        {
            filterByName = string.IsNullOrWhiteSpace(filterByName) ? "" : filterByName.Trim();

            var model = productoService.GetAll(filterByName, filterByCategoria, filterByMarca);
            return PartialView("Index2Resultado", model);
        }

        public ActionResult Index3(string filterByName, int? filterByCategoria, int? filterByMarca)
        {
            filterByName = string.IsNullOrWhiteSpace(filterByName) ? "" : filterByName.Trim();

            ViewBag.Categorias = categoriaService.GetAll("");
            ViewBag.Marcas = marcaService.GetAll("");

            return View();
        }
        public JsonResult Index3Buscar(string filterByName, int? filterByCategoria, int? filterByMarca)
        {
            filterByName = string.IsNullOrWhiteSpace(filterByName) ? "" : filterByName.Trim();

            var model = productoService.GetAll(filterByName, filterByCategoria, filterByMarca);
            JsonSerializerSettings config = new JsonSerializerSettings
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            };
            var model2 = JsonConvert.SerializeObject(model, Formatting.Indented, config);
            return Json(model2);
        }

        public ActionResult Create()
        {
            ViewBag.Categorias = categoriaService.GetAll("");
            ViewBag.Marcas = marcaService.GetAll("");
            ViewBag.UnidadMedidas = unidadMedidaService.GetAll("");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Producto model, int? filterByCategoria, int? filterByMarca, int? filterByUnidadMedida)
        {


            model.CategoriaID = filterByCategoria.Value;
            model.MarcaID = filterByMarca.Value;
            model.UnidadMedidaID = filterByUnidadMedida.Value;
            model.Estado = true;


            var result = productoService.Save(model);

            return RedirectToAction("index");
        }

        public ActionResult Edit(int id)
        {
            var model = productoService.GetById(id);
            ViewBag.Categorias = categoriaService.GetAll("");
            ViewBag.Marcas = marcaService.GetAll("");
            ViewBag.UnidadMedidas = unidadMedidaService.GetAll("");
            return View("Create", model);
        }

        [HttpPost]
        public ActionResult Edit(Producto model, int? filterByCategoria, int? filterByMarca, int? filterByUnidadMedida)
        {
            model.CategoriaID = filterByCategoria.Value;
            model.MarcaID = filterByMarca.Value;
            model.UnidadMedidaID = filterByUnidadMedida.Value;
            model.Estado = true;

            var result = productoService.Save(model);
            return RedirectToAction("Index");
        }
    }
}