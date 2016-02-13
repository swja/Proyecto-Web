namespace Proyecto_Web
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CnxModel : DbContext
    {
        public CnxModel()
            : base("name=CnxModel")
        {
        }

        public virtual DbSet<documentos> documentos { get; set; }
        public virtual DbSet<tipo_documento> tipo_documento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<documentos>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<documentos>()
                .Property(e => e.Nom_doc_encon)
                .IsUnicode(false);

            modelBuilder.Entity<documentos>()
                .Property(e => e.Ape_doc_encon)
                .IsUnicode(false);

            modelBuilder.Entity<documentos>()
                .Property(e => e.Ced_per_encon)
                .IsUnicode(false);

            modelBuilder.Entity<documentos>()
                .Property(e => e.Nom_pers_encon)
                .IsUnicode(false);

            modelBuilder.Entity<documentos>()
                .Property(e => e.Ape_perso_encon)
                .IsUnicode(false);

            modelBuilder.Entity<documentos>()
                .Property(e => e.Nmr_contacto)
                .IsUnicode(false);

            modelBuilder.Entity<documentos>()
                .Property(e => e.Email_contacto)
                .IsUnicode(false);

            modelBuilder.Entity<documentos>()
                .Property(e => e.Lugar_encon)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_documento>()
                .Property(e => e.Tipo_doc)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_documento>()
                .HasMany(e => e.documentos)
                .WithRequired(e => e.tipo_documento)
                .WillCascadeOnDelete(false);
        }
    }
}
