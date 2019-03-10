namespace App.Entidad.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("seguridad.RegistroOcurrencia")]
    public partial class RegistroOcurrencia
    {
        public int RegistroOcurrenciaId { get; set; }

        public int? AtencionPuestoId { get; set; }

        public int? TipoOcurrenciaId { get; set; }

        public string detalleOcurrencia { get; set; }

        [StringLength(8)]
        public string Hora { get; set; }

        public int? UsuarioId { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public int? UsuarioModificacionId { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public virtual AtencionPuesto AtencionPuesto { get; set; }

        public virtual TipoOcurrencia TipoOcurrencia { get; set; }
    }
}
