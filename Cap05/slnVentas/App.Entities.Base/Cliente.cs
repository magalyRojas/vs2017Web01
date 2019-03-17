namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Cliente")]
    public partial class Cliente
    {
        public int ClienteID { get; set; }

        public string DocumentoIdentidad { get; set; }
        [Required]
        [StringLength(100)]
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        
    }
}
