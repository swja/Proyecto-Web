namespace Proyecto_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("aplicación.tipo_documento")]
    public partial class tipo_documento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipo_documento()
        {
            documentos = new HashSet<documentos>();
        }

        [Key]
        public int id_tipo_doc { get; set; }

        [Required]
        [StringLength(45)]
        public string Tipo_doc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documentos> documentos { get; set; }
    }
}
