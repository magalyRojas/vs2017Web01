namespace App.Entidad.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("seguridad.AtencionPuesto")]
    public partial class AtencionPuesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AtencionPuesto()
        {
            RegistroOcurrencia = new HashSet<RegistroOcurrencia>();
            RegistroVisita = new HashSet<RegistroVisita>();
            RegistroVisita1 = new HashSet<RegistroVisita>();
        }

        public int AtencionPuestoId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [StringLength(8)]
        public string Hora { get; set; }

        public int? UsuarioJefeId { get; set; }

        public int? PuestoVigilanciaId { get; set; }

        public int? TurnoId { get; set; }

        public int? UsuarioEntradaId { get; set; }

        public int? UsuarioSalidaId { get; set; }

        public string Observacion { get; set; }

        public virtual PuestoVigilancia PuestoVigilancia { get; set; }

        public virtual Turno Turno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroOcurrencia> RegistroOcurrencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroVisita> RegistroVisita { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroVisita> RegistroVisita1 { get; set; }
    }
}
