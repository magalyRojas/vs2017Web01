using System;
using App.Entities.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace App.Data.DataBase.Test
{
    [TestClass]
    public class CategoriaTest
    {
        [TestMethod]
        public void NuevaCategoria()
        {
            using (var model = new AppModel())
            {
                var categoria = new Categoria()
                {
                    Nombre = "Mouse",
                    Estado = true
                };

                model.Categoria.Add(categoria);
                model.SaveChanges(); //es requerido para confirmar la transacción en EF
                //verificando que se este creando la categoria
                Assert.IsTrue(categoria.CategoriaID > 0);
            }
        }
        [TestMethod]
        public void VerificarRegistros()
        {
            using(var model = new AppModel())
            {
                var cantidad = model.Categoria.Count();
                Assert.IsTrue(cantidad > 0);
                               
            }
        }
    }
}
