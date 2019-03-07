namespace App.Entidad.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("general.Area")]
    public partial class Area
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Area()
        {
            PersonalTrayectoria = new HashSet<PersonalTrayectoria>();
        }

        [Key]
        public int idArea { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }

        public int? idLocal { get; set; }

        [StringLength(20)]
        public string inicial { get; set; }

        public int? nivel { get; set; }

        public int? idOficinaDepende { get; set; }

        public int? idTipE { get; set; }

        [StringLength(6)]
        public string CentroCosto { get; set; }

        [StringLength(4)]
        public string NroMetaSiaf { get; set; }

        [StringLength(4)]
        public string CodigoArea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalTrayectoria> PersonalTrayectoria { get; set; }
    }
}
