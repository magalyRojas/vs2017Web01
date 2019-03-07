namespace App.Entidad.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("recursosHumanos.PersonalTrayectoria")]
    public partial class PersonalTrayectoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonalTrayectoria()
        {
            RegistroVisita = new HashSet<RegistroVisita>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idPersonal { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte idCorrelativo { get; set; }

        public int idArea { get; set; }

        [Required]
        [StringLength(3)]
        public string idCargo { get; set; }

        public byte idTipoTrabajador { get; set; }

        public byte idTipoTrabajadorDetalle { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaIngreso { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaCese { get; set; }

        [Required]
        public string observacion { get; set; }

        public virtual Area Area { get; set; }

        public virtual Personal Personal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroVisita> RegistroVisita { get; set; }
    }
}
