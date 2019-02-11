using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.UI.Web.MVC.Models.ViewModels
{
    public class ProductoSearchViewModel
    {
        public string filterByName { get; set; }
        public int filterByCategoria { get; set; }
        public int filterByMarca { get; set; }
        public List<Categoria> Categorias { get; set; }

        public List<Marca> Marcas { get; set; }
        public List<Producto> Productos { get; set; }
    }
}