namespace App.Entidad.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("recursosHumanos.Personal")]
    public partial class Personal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personal()
        {
            PersonalTrayectoria = new HashSet<PersonalTrayectoria>();
        }

        [Key]
        public int idPersonal { get; set; }

        [Required]
        [StringLength(50)]
        public string apellidoPaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string apellidoMaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string nombres { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaNacimiento { get; set; }

        public byte idDocumentoIdentidad { get; set; }

        [Required]
        [StringLength(20)]
        public string nroDocumento { get; set; }

        [StringLength(11)]
        public string nroRuc { get; set; }

        [StringLength(15)]
        public string nroAutogenerado { get; set; }

        public byte idSexo { get; set; }

        public byte idEstadoCivil { get; set; }

        public byte idFormaPago { get; set; }

        public byte? idBanco { get; set; }

        [StringLength(20)]
        public string nroCuenta { get; set; }

        public byte idRegimenPension { get; set; }

        public byte? idAfp { get; set; }

        [StringLength(20)]
        public string nroCuspp { get; set; }

        public byte? idTipoComision { get; set; }

        public bool? essaludVida { get; set; }

        public bool? cuotaSindical { get; set; }

        public bool? cuotaMortuoria { get; set; }

        public bool? cuotaCooperativa { get; set; }

        [Required]
        [StringLength(3)]
        public string idPostal { get; set; }

        [Required]
        [StringLength(99)]
        public string domicilioFiscal { get; set; }

        [StringLength(90)]
        public string correoElectronico { get; set; }

        [StringLength(30)]
        public string telefono { get; set; }

        [StringLength(5)]
        public string oldCodigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalTrayectoria> PersonalTrayectoria { get; set; }
    }
}
