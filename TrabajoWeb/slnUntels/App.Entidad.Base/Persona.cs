namespace App.Entidad.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    [Table("general.Persona")]
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            RegistroVisita = new HashSet<RegistroVisita>();
        }

        public int PersonaId { get; set; }

        [StringLength(70)]
        public string ApellidoPaterno { get; set; }

        [StringLength(70)]
        public string ApellidoMaterno { get; set; }

        [StringLength(70)]
        public string Nombres { get; set; }

        public int? GeneroID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }

        public int? TipoPersonaId { get; set; }

        public int? TipoDocumento { get; set; }

        [StringLength(15)]
        public string NumeroDocumento { get; set; }

        [StringLength(6)]
        public string UbigeoNacimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroVisita> RegistroVisita { get; set; }
    }
}
