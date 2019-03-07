namespace App.Entidad.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("seguridad.RegistroVisita")]
    public partial class RegistroVisita
    {
        public int RegistroVisitaId { get; set; }

        public int? PersonaId { get; set; }

        public int? MotivoVisitaId { get; set; }

        [StringLength(8)]
        public string HoraEntrada { get; set; }

        [StringLength(8)]
        public string HoraSalida { get; set; }

        public int? areaId { get; set; }

        public int? PersonalId { get; set; }

        public int? AtencionPuestoId { get; set; }

        public int? AtencionPuestoSalidaId { get; set; }

        public string observacion { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public int usuarioCreacionId { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public int? usuarioModificacionId { get; set; }

        public byte? correlativoId { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual PersonalTrayectoria PersonalTrayectoria { get; set; }

        public virtual AtencionPuesto AtencionPuesto { get; set; }

        public virtual AtencionPuesto AtencionPuesto1 { get; set; }

        public virtual MotivoVisita MotivoVisita { get; set; }
    }
}
