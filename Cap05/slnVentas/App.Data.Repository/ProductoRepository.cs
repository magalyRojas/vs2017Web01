using App.Data.Repository.Interfaces;
using App.Entities.Base;
using App.Entities.Queries;
using App.Entities.Queries.Filtros;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class ProductoRepository :
        GenericRepository<Producto>, IProductoRepository
    {
        public ListaPaginada<ProductoSearch> BuscarProductosStock(ProductoSearchFiltros filtros)
        {
            var result = new ListaPaginada<ProductoSearch>();
            filtros.Nombre = filtros.Nombre ?? "";
            // para la paginacion es necesario que este ordenado
            //con orderby
            var query = from a in context.Set<Categoria>()
                        join b in context.Set<Producto>()
                        on a.CategoriaID equals b.CategoriaID
                        join c in context.Set<Marca>()
                        on b.MarcaID equals c.MarcaID
                        where b.Nombre.Contains(filtros.Nombre)
                        && b.StockActual>filtros.Stock
                        orderby a.Nombre
                        select new ProductoSearch()
                        {
                            ProductoID = b.ProductoID,
                            Nombre = b.Nombre,
                            CategoriaName = a.Nombre,
                            PrecioMayor = b.PrecioMayor,
                            PrecioMenor = b.PrecioMenor,
                            StockActual = b.StockActual,
                            ProductoCode = b.ProductoCode,
                            MarcaName = c.Nombre
                        };
            //primero se obtine la cantidad de registros
            result.TotalRows = query.Count();

            //finalmente se pagina en el servidor
            
            query = query.Skip(filtros.PageSize * (filtros.PageIndex - 1));
            //se toman los registros  restanes según el tamaño de pagina
            query = query.Take(filtros.PageSize);

            result.Listado = query.ToList();

            return result;
        }
        public ProductoRepository(DbContext Context) : base(Context)
        {

        }
    }
}
