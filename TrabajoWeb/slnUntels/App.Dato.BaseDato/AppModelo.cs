namespace App.Dato.BaseDato
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppModelo : DbContext
    {
        public AppModelo()
            : base("name=AppModelo1")
        {
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<PersonalTrayectoria> PersonalTrayectoria { get; set; }
        public virtual DbSet<AtencionPuesto> AtencionPuesto { get; set; }
        public virtual DbSet<MotivoVisita> MotivoVisita { get; set; }
        public virtual DbSet<PuestoVigilancia> PuestoVigilancia { get; set; }
        public virtual DbSet<RegistroOcurrencia> RegistroOcurrencia { get; set; }
        public virtual DbSet<RegistroVisita> RegistroVisita { get; set; }
        public virtual DbSet<TipoOcurrencia> TipoOcurrencia { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Area>()
                .Property(e => e.inicial)
                .IsUnicode(false);

            modelBuilder.Entity<Area>()
                .Property(e => e.CentroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<Area>()
                .Property(e => e.NroMetaSiaf)
                .IsUnicode(false);

            modelBuilder.Entity<Area>()
                .Property(e => e.CodigoArea)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Area>()
                .HasMany(e => e.PersonalTrayectoria)
                .WithRequired(e => e.Area)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.NumeroDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.UbigeoNacimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.apellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.apellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.nroDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.nroRuc)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.nroAutogenerado)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.nroCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.nroCuspp)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.idPostal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.domicilioFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.correoElectronico)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.oldCodigo)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .HasMany(e => e.PersonalTrayectoria)
                .WithRequired(e => e.Personal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonalTrayectoria>()
                .Property(e => e.idCargo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PersonalTrayectoria>()
                .Property(e => e.observacion)
                .IsUnicode(false);

            modelBuilder.Entity<PersonalTrayectoria>()
                .HasMany(e => e.RegistroVisita)
                .WithOptional(e => e.PersonalTrayectoria)
                .HasForeignKey(e => new { e.PersonalId, e.correlativoId });

            modelBuilder.Entity<AtencionPuesto>()
                .Property(e => e.Hora)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AtencionPuesto>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<AtencionPuesto>()
                .HasMany(e => e.RegistroVisita)
                .WithOptional(e => e.AtencionPuesto)
                .HasForeignKey(e => e.AtencionPuestoId);

            modelBuilder.Entity<AtencionPuesto>()
                .HasMany(e => e.RegistroVisita1)
                .WithOptional(e => e.AtencionPuesto1)
                .HasForeignKey(e => e.AtencionPuestoSalidaId);

            modelBuilder.Entity<MotivoVisita>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PuestoVigilancia>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroOcurrencia>()
                .Property(e => e.detalleOcurrencia)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroOcurrencia>()
                .Property(e => e.Hora)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RegistroVisita>()
                .Property(e => e.HoraEntrada)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RegistroVisita>()
                .Property(e => e.HoraSalida)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RegistroVisita>()
                .Property(e => e.observacion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoOcurrencia>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Turno>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);
        }
    }
}
