using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.UI.Web.MVC.ModelBinders
{
    public class ClienteBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Cliente model = new Cliente();

            model.DocumentoIdentidad = HttpContext.Current.Request.Form["DocumentoIdentidad"];
            model.ApellidoPaterno = HttpContext.Current.Request.Form["ApellidoPaterno"];
            model.ApellidoMaterno = HttpContext.Current.Request.Form["ApellidoMaterno"];
            model.Nombre = HttpContext.Current.Request.Form["Nombre"];
            model.Direccion = HttpContext.Current.Request.Form["Direccion"];
            
            return model;
        }
    }
}