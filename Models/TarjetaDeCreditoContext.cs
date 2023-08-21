using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    public partial class TarjetaDeCreditoContext : DbContext
    {
        public TarjetaDeCreditoContext()
        {
        }

        public TarjetaDeCreditoContext(DbContextOptions<TarjetaDeCreditoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ciudad> Ciudads { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Comite> Comites { get; set; } = null!;
        public virtual DbSet<Comitexempleado> Comitexempleados { get; set; } = null!;
        public virtual DbSet<CompaniaTarjetum> CompaniaTarjeta { get; set; } = null!;
        public virtual DbSet<Cuentum> Cuenta { get; set; } = null!;
        public virtual DbSet<DatosLaborale> DatosLaborales { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<DepartamentoBanco> DepartamentoBancos { get; set; } = null!;
        public virtual DbSet<Direccion> Direccions { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<EstadoCuentum> EstadoCuenta { get; set; } = null!;
        public virtual DbSet<EstadoSolicitud> EstadoSolicituds { get; set; } = null!;
        public virtual DbSet<Estatus> Estatuses { get; set; } = null!;
        public virtual DbSet<Extrafinanciamiento> Extrafinanciamientos { get; set; } = null!;
        public virtual DbSet<HistorialTransaccione> HistorialTransacciones { get; set; } = null!;
        public virtual DbSet<Mora> Moras { get; set; } = null!;
        public virtual DbSet<Municipio> Municipios { get; set; } = null!;
        public virtual DbSet<Ocupacion> Ocupacions { get; set; } = null!;
        public virtual DbSet<PagoCredito> PagoCreditos { get; set; } = null!;
        public virtual DbSet<Pai> Pais { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Puesto> Puestos { get; set; } = null!;
        public virtual DbSet<Queja> Quejas { get; set; } = null!;
        public virtual DbSet<ReferenciaPersonal> ReferenciaPersonals { get; set; } = null!;
        public virtual DbSet<SolicitudTarjetum> SolicitudTarjeta { get; set; } = null!;
        public virtual DbSet<Sucursal> Sucursals { get; set; } = null!;
        public virtual DbSet<Tarjetum> Tarjeta { get; set; } = null!;
        public virtual DbSet<Telefono> Telefonos { get; set; } = null!;
        public virtual DbSet<Telefonosucursal> Telefonosucursals { get; set; } = null!;
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; } = null!;
        public virtual DbSet<TipoPersona> TipoPersonas { get; set; } = null!;
        public virtual DbSet<TipoTransaccion> TipoTransaccions { get; set; } = null!;
        public virtual DbSet<Transaccione> Transacciones { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.Property(e => e.CiudadId).ValueGeneratedNever();

                entity.HasOne(d => d.Municipio)
                    .WithMany(p => p.Ciudads)
                    .HasForeignKey(d => d.MunicipioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("municipiofk");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.ClienteId).ValueGeneratedNever();

                entity.HasOne(d => d.DatosLaborales)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.DatosLaboralesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("datos_laboralesfk");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.PersonaId)
                    .HasConstraintName("personaclifk");
            });

            modelBuilder.Entity<Comite>(entity =>
            {
                entity.Property(e => e.ComiteId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Comitexempleado>(entity =>
            {
                entity.HasOne(d => d.Comite)
                    .WithMany()
                    .HasForeignKey(d => d.ComiteId)
                    .HasConstraintName("comiteempleadofk");

                entity.HasOne(d => d.Empleado)
                    .WithMany()
                    .HasForeignKey(d => d.EmpleadoId)
                    .HasConstraintName("empleadocomitefk");
            });

            modelBuilder.Entity<CompaniaTarjetum>(entity =>
            {
                entity.HasKey(e => e.CompaniaId)
                    .HasName("companiapk");

                entity.Property(e => e.CompaniaId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Cuentum>(entity =>
            {
                entity.HasKey(e => e.CuentaId)
                    .HasName("cuentapk");

                entity.Property(e => e.CuentaId).ValueGeneratedNever();

                entity.Property(e => e.NumCuenta).IsFixedLength();

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientefk");
            });

            modelBuilder.Entity<DatosLaborale>(entity =>
            {
                entity.HasKey(e => e.DatosLaboralesId)
                    .HasName("Datos_LaboralesPK");

                entity.HasOne(d => d.Ocupacion)
                    .WithMany(p => p.DatosLaborales)
                    .HasForeignKey(d => d.OcupacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ocupacionfk");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.Property(e => e.DepartamentoId).ValueGeneratedNever();

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("paisdeptofk");
            });

            modelBuilder.Entity<DepartamentoBanco>(entity =>
            {
                entity.Property(e => e.DepartamentoBancoid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Direccion>(entity =>
            {
                entity.HasOne(d => d.Cuidad)
                    .WithMany(p => p.Direccions)
                    .HasForeignKey(d => d.Cuidadid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cuidadfk");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Direccions)
                    .HasForeignKey(d => d.Departamentoid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("departamentodirecfk");

                entity.HasOne(d => d.Municipio)
                    .WithMany(p => p.Direccions)
                    .HasForeignKey(d => d.Municipioid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("municipioidfk");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Direccions)
                    .HasForeignKey(d => d.Paisid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("paisfk");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.Property(e => e.EmpleadoId).ValueGeneratedNever();

                entity.HasOne(d => d.DepartamentoBanco)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.DepartamentoBancoid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("depatemantoemplefk");

                entity.HasOne(d => d.Persona)
                    .WithOne(p => p.Empleado)
                    .HasForeignKey<Empleado>(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("personaempfk");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sucursalemplfk");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.Property(e => e.Estadoid).ValueGeneratedNever();
            });

            modelBuilder.Entity<EstadoCuentum>(entity =>
            {
                entity.HasKey(e => e.EstadoCuentaId)
                    .HasName("estado_cuentapk");

                entity.Property(e => e.EstadoCuentaId).ValueGeneratedNever();

                entity.Property(e => e.NumCuenta).IsFixedLength();

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.EstadoCuenta)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientefk");

                entity.HasOne(d => d.Cuenta)
                    .WithMany(p => p.EstadoCuenta)
                    .HasForeignKey(d => d.CuentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cuentaesdfk");
            });

            modelBuilder.Entity<EstadoSolicitud>(entity =>
            {
                entity.Property(e => e.EstadoSolicitudid).ValueGeneratedNever();

                entity.HasOne(d => d.Comite)
                    .WithMany(p => p.EstadoSolicituds)
                    .HasForeignKey(d => d.ComiteId)
                    .HasConstraintName("comitesolicitudfk");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.EstadoSolicituds)
                    .HasForeignKey(d => d.Estadoid)
                    .HasConstraintName("estadofk");
            });

            modelBuilder.Entity<Estatus>(entity =>
            {
                entity.Property(e => e.EstatusId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Extrafinanciamiento>(entity =>
            {
                entity.Property(e => e.ExtrafinanciamientoId).ValueGeneratedNever();

                entity.HasOne(d => d.Tarjeta)
                    .WithMany(p => p.Extrafinanciamientos)
                    .HasForeignKey(d => d.TarjetaId)
                    .HasConstraintName("tarjetaextrafk");
            });

            modelBuilder.Entity<HistorialTransaccione>(entity =>
            {
                entity.HasKey(e => e.HistorialTransaccionesid)
                    .HasName("historial_transaccionespk");

                entity.Property(e => e.HistorialTransaccionesid).ValueGeneratedNever();

                entity.HasOne(d => d.Transaccion)
                    .WithMany(p => p.HistorialTransacciones)
                    .HasForeignKey(d => d.TransaccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transaccionfk");
            });

            modelBuilder.Entity<Mora>(entity =>
            {
                entity.Property(e => e.Moraid).ValueGeneratedNever();

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Moras)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("clientemorafk");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.Moras)
                    .HasForeignKey(d => d.Estatusid)
                    .HasConstraintName("EstatusID");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.Property(e => e.MunicipioId).ValueGeneratedNever();

                entity.HasOne(d => d.Departamento)
                    .WithOne(p => p.Municipio)
                    .HasForeignKey<Municipio>(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("departamentomunifk");
            });

            modelBuilder.Entity<Ocupacion>(entity =>
            {
                entity.Property(e => e.OcupacionId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PagoCredito>(entity =>
            {
                entity.Property(e => e.PagoCreditoid).ValueGeneratedNever();

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.PagoCreditos)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("clientepago");
            });

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.HasKey(e => e.PaisId)
                    .HasName("paispk");

                entity.Property(e => e.PaisId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasOne(d => d.Direccion)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.DireccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("direccionpfk");

                entity.HasOne(d => d.TipoDocumento)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.TipoDocumentoid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tipo_documentofk");

                entity.HasOne(d => d.TipoPersona)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.TipoPersonaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tipo_personaidpfk");
            });

            modelBuilder.Entity<Puesto>(entity =>
            {
                entity.Property(e => e.PuestoId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Queja>(entity =>
            {
                entity.HasKey(e => e.QuejasId)
                    .HasName("quejapk");

                entity.Property(e => e.QuejasId).ValueGeneratedNever();

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Quejas)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("clientequejafk");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Quejas)
                    .HasForeignKey(d => d.EmpleadoId)
                    .HasConstraintName("empleadosquejasfk");
            });

            modelBuilder.Entity<ReferenciaPersonal>(entity =>
            {
                entity.HasKey(e => e.ReferenciaId)
                    .HasName("referencia_personal_pkey");

                entity.Property(e => e.ReferenciaId).ValueGeneratedNever();

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.ReferenciaPersonals)
                    .HasForeignKey(d => d.PersonaId)
                    .HasConstraintName("PersonaFK");
            });

            modelBuilder.Entity<SolicitudTarjetum>(entity =>
            {
                entity.HasKey(e => e.SolicitudId)
                    .HasName("solicitudpk");

                entity.Property(e => e.SolicitudId).ValueGeneratedNever();

                entity.HasOne(d => d.Direccion)
                    .WithMany(p => p.SolicitudTarjeta)
                    .HasForeignKey(d => d.DireccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("direccionsolicitudfk");

                entity.HasOne(d => d.EstadoSolicitud)
                    .WithMany(p => p.SolicitudTarjeta)
                    .HasForeignKey(d => d.EstadoSolicitudid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("estado_solicitudslicitudfk");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.SolicitudTarjeta)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("personasolicitudfk");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.SolicitudTarjeta)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sucursalsolicitudfk");

                entity.HasOne(d => d.Tarjeta)
                    .WithMany(p => p.SolicitudTarjeta)
                    .HasForeignKey(d => d.TarjetaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tarjetasolicitudfk");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.Property(e => e.SucursalId).ValueGeneratedNever();

                entity.HasOne(d => d.Direccion)
                    .WithMany(p => p.Sucursals)
                    .HasForeignKey(d => d.DireccionId)
                    .HasConstraintName("direccionsucurfk");
            });

            modelBuilder.Entity<Tarjetum>(entity =>
            {
                entity.HasKey(e => e.TarjetaId)
                    .HasName("tarjetapk");

                entity.Property(e => e.TarjetaId).ValueGeneratedNever();

                entity.Property(e => e.Cvc).IsFixedLength();

                entity.Property(e => e.NumeroTarjeta).IsFixedLength();

                entity.Property(e => e.Pin).IsFixedLength();

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Tarjeta)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientefk");

                entity.HasOne(d => d.Compania)
                    .WithMany(p => p.Tarjeta)
                    .HasForeignKey(d => d.CompaniaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("companiafk");

                entity.HasOne(d => d.Cuenta)
                    .WithMany(p => p.Tarjeta)
                    .HasForeignKey(d => d.Cuentaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cuentafk");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.Tarjeta)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sucursaltarjetafk");
            });

            modelBuilder.Entity<Telefono>(entity =>
            {
                entity.Property(e => e.NumTelefono).IsFixedLength();

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Telefonos)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("paisfk");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Telefonos)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("personatelfk");
            });

            modelBuilder.Entity<Telefonosucursal>(entity =>
            {
                entity.HasKey(e => e.Telefonoid)
                    .HasName("telefonosucurpk");

                entity.Property(e => e.Telefonoid).ValueGeneratedNever();

                entity.Property(e => e.NumTelefono).IsFixedLength();

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.Telefonosucursals)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sucursaltelfk");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.Property(e => e.TipoDocumentoid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TipoPersona>(entity =>
            {
                entity.Property(e => e.TipoPersonaid).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).IsFixedLength();
            });

            modelBuilder.Entity<TipoTransaccion>(entity =>
            {
                entity.Property(e => e.TipoTransaccionid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Transaccione>(entity =>
            {
                entity.HasKey(e => e.Transaccionesid)
                    .HasName("transaccionespk");

                entity.Property(e => e.Transaccionesid).ValueGeneratedNever();

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.Transacciones)
                    .HasForeignKey(d => d.CiudadId)
                    .HasConstraintName("cuidadtrfk");

                entity.HasOne(d => d.Tarjeta)
                    .WithMany(p => p.Transacciones)
                    .HasForeignKey(d => d.TarjetaId)
                    .HasConstraintName("tarjetatrfk");

                entity.HasOne(d => d.TipoTransaccion)
                    .WithMany(p => p.Transacciones)
                    .HasForeignKey(d => d.TipoTransaccionid)
                    .HasConstraintName("tipo_transaccionfk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
