namespace Aplicacion_web1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("webaplicación.documentos")]
    public partial class documentos
    {
        [Key]
        public int id_doc { get; set; }

        public int id_tipo_doc { get; set; }

        [StringLength(10)]
        public string Cedula { get; set; }

        [Required]
        [StringLength(35)]
        public string Nom_doc_encon { get; set; }

        [Required]
        [StringLength(35)]
        public string Ape_doc_encon { get; set; }

        [StringLength(10)]
        public string Ced_per_encon { get; set; }

        [Required]
        [StringLength(35)]
        public string Nom_pers_encon { get; set; }

        [Required]
        [StringLength(35)]
        public string Ape_perso_encon { get; set; }

        [StringLength(10)]
        public string Nmr_contacto { get; set; }

        [Required]
        [StringLength(45)]
        public string Email_contacto { get; set; }

        [Required]
        [StringLength(50)]
        public string Lugar_encon { get; set; }

        public DateTime? Fecha_registro { get; set; }

        public virtual tipo_documento tipo_documento { get; set; }
    }
}
