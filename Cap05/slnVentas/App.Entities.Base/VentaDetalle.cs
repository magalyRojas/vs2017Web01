using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.Base
{
    [Table("VentaDetalle")]
    public class VentaDetalle
    {

        public int VentaDetalleId { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public decimal SubTotal { get; set; }

        //para asociar
        public virtual Venta Venta { get; set; } 

    }
}
