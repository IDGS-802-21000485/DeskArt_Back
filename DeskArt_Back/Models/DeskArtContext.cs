using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DeskArt_Back.Models;

public partial class DeskArtContext : DbContext
{
    public DeskArtContext()
    {
    }

    public DeskArtContext(DbContextOptions<DeskArtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CompraProd> CompraProds { get; set; }

    public virtual DbSet<CompraTotal> CompraTotals { get; set; }

    public virtual DbSet<EstadoProduc> EstadoProducs { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<LoginMobil> LoginMobils { get; set; }

    public virtual DbSet<MateriaP> MateriaPs { get; set; }

    public virtual DbSet<Merma> Mermas { get; set; }

    public virtual DbSet<Producción> Produccións { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<ProveedorHasMateriaP> ProveedorHasMateriaPs { get; set; }

    public virtual DbSet<Recetum> Receta { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioTiendum> UsuarioTienda { get; set; }

    public virtual DbSet<VentaProd> VentaProds { get; set; }

    public virtual DbSet<VentaTotal> VentaTotals { get; set; }

    public virtual DbSet<Área> Áreas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompraProd>(entity =>
        {
            entity.HasKey(e => e.IdCompraProd).HasName("PK__CompraPr__84671237758CC721");

            entity.ToTable("CompraProd");

            entity.Property(e => e.IdCompraProd)
                .ValueGeneratedNever()
                .HasColumnName("idCompraProd");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.ProveedorHasMateriaPIdProveedorHasMateriaP).HasColumnName("Proveedor_has_MateriaP_idProveedor_has_MateriaP");
            entity.Property(e => e.SubTotal).HasColumnName("subTotal");

            entity.HasOne(d => d.ProveedorHasMateriaPIdProveedorHasMateriaPNavigation).WithMany(p => p.CompraProds)
                .HasForeignKey(d => d.ProveedorHasMateriaPIdProveedorHasMateriaP)
                .HasConstraintName("FK__CompraPro__Prove__5629CD9C");
        });

        modelBuilder.Entity<CompraTotal>(entity =>
        {
            entity.HasKey(e => e.IdCompra).HasName("PK__CompraTo__48B99DB7B0AC5DEF");

            entity.ToTable("CompraTotal");

            entity.Property(e => e.IdCompra)
                .ValueGeneratedNever()
                .HasColumnName("idCompra");
            entity.Property(e => e.CompraProdIdCompraProd).HasColumnName("CompraProd_idCompraProd");
            entity.Property(e => e.Descripción)
                .HasColumnType("text")
                .HasColumnName("descripción");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.CompraProdIdCompraProdNavigation).WithMany(p => p.CompraTotals)
                .HasForeignKey(d => d.CompraProdIdCompraProd)
                .HasConstraintName("FK__CompraTot__Compr__59063A47");
        });

        modelBuilder.Entity<EstadoProduc>(entity =>
        {
            entity.HasKey(e => e.IdEstadoProduc).HasName("PK__EstadoPr__424B98253C2EB35D");

            entity.ToTable("EstadoProduc");

            entity.Property(e => e.IdEstadoProduc)
                .ValueGeneratedNever()
                .HasColumnName("idEstadoProduc");
            entity.Property(e => e.Descripción)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("descripción");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.IdInventario).HasName("PK__Inventar__8F145B0D855528AE");

            entity.ToTable("Inventario");

            entity.Property(e => e.IdInventario)
                .ValueGeneratedNever()
                .HasColumnName("idInventario");
            entity.Property(e => e.Cantidad)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("cantidad");
            entity.Property(e => e.MateriaPIdMateriaP).HasColumnName("MateriaP_idMateriaP");

            entity.HasOne(d => d.MateriaPIdMateriaPNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.MateriaPIdMateriaP)
                .HasConstraintName("FK__Inventari__Mater__4D94879B");
        });

        modelBuilder.Entity<LoginMobil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoginMob__3213E83FB7093301");

            entity.ToTable("LoginMobil");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(100)
                .HasColumnName("contrasena");
            entity.Property(e => e.Cp)
                .HasMaxLength(10)
                .HasColumnName("cp");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sexo");
        });

        modelBuilder.Entity<MateriaP>(entity =>
        {
            entity.HasKey(e => e.IdMateriaP).HasName("PK__MateriaP__6AC7E38FCB3B1ABF");

            entity.ToTable("MateriaP");

            entity.Property(e => e.IdMateriaP)
                .ValueGeneratedNever()
                .HasColumnName("idMateriaP");
            entity.Property(e => e.Medida)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("medida");
            entity.Property(e => e.Nombre)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Merma>(entity =>
        {
            entity.HasKey(e => e.IdMerma).HasName("PK__Merma__248B3BCB52CBCF38");

            entity.ToTable("Merma");

            entity.Property(e => e.IdMerma)
                .ValueGeneratedNever()
                .HasColumnName("idMerma");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Descripción)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("descripción");
            entity.Property(e => e.MateriaPIdMateriaP).HasColumnName("MateriaP_idMateriaP");
            entity.Property(e => e.UsuarioTiendaIdUsuarioTienda).HasColumnName("UsuarioTienda_idUsuarioTienda");

            entity.HasOne(d => d.MateriaPIdMateriaPNavigation).WithMany(p => p.Mermas)
                .HasForeignKey(d => d.MateriaPIdMateriaP)
                .HasConstraintName("FK__Merma__MateriaP___49C3F6B7");

            entity.HasOne(d => d.UsuarioTiendaIdUsuarioTiendaNavigation).WithMany(p => p.Mermas)
                .HasForeignKey(d => d.UsuarioTiendaIdUsuarioTienda)
                .HasConstraintName("FK__Merma__UsuarioTi__4AB81AF0");
        });

        modelBuilder.Entity<Producción>(entity =>
        {
            entity.HasKey(e => e.IdProducción).HasName("PK__Producci__CB8C74FD85D28C56");

            entity.ToTable("Producción");

            entity.Property(e => e.IdProducción)
                .ValueGeneratedNever()
                .HasColumnName("idProducción");
            entity.Property(e => e.EstadoProducIdEstadoProduc).HasColumnName("EstadoProduc_idEstadoProduc");
            entity.Property(e => e.VentaTotalIdVentaTotal).HasColumnName("VentaTotal_idVentaTotal");

            entity.HasOne(d => d.EstadoProducIdEstadoProducNavigation).WithMany(p => p.Produccións)
                .HasForeignKey(d => d.EstadoProducIdEstadoProduc)
                .HasConstraintName("FK__Producció__Estad__66603565");

            entity.HasOne(d => d.VentaTotalIdVentaTotalNavigation).WithMany(p => p.Produccións)
                .HasForeignKey(d => d.VentaTotalIdVentaTotal)
                .HasConstraintName("FK__Producció__Venta__656C112C");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__07F4A13277F9AE81");

            entity.ToTable("Producto");

            entity.Property(e => e.IdProducto)
                .ValueGeneratedNever()
                .HasColumnName("idProducto");
            entity.Property(e => e.Alto)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("alto");
            entity.Property(e => e.Ancho)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("ancho");
            entity.Property(e => e.Largo)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("largo");
            entity.Property(e => e.Precio)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("precio");
            entity.Property(e => e.ÁreaIdÁrea).HasColumnName("Área_idÁrea");

            entity.HasOne(d => d.ÁreaIdÁreaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.ÁreaIdÁrea)
                .HasConstraintName("FK__Producto__Área_i__412EB0B6");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__Proveedo__A3FA8E6BFE263A82");

            entity.ToTable("Proveedor");

            entity.Property(e => e.IdProveedor)
                .ValueGeneratedNever()
                .HasColumnName("idProveedor");
            entity.Property(e => e.Correo)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Empresa)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("empresa");
            entity.Property(e => e.Nombrep)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nombrep");
            entity.Property(e => e.Telefono)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<ProveedorHasMateriaP>(entity =>
        {
            entity.HasKey(e => e.IdProveedorHasMateriaP).HasName("PK__Proveedo__DCB9816B3AD06BB7");

            entity.ToTable("Proveedor_has_MateriaP");

            entity.Property(e => e.IdProveedorHasMateriaP)
                .ValueGeneratedNever()
                .HasColumnName("idProveedor_has_MateriaP");
            entity.Property(e => e.MateriaPIdMateriaP1).HasColumnName("MateriaP_idMateriaP1");
            entity.Property(e => e.ProveedorIdProveedor1).HasColumnName("Proveedor_idProveedor1");

            entity.HasOne(d => d.MateriaPIdMateriaP1Navigation).WithMany(p => p.ProveedorHasMateriaPs)
                .HasForeignKey(d => d.MateriaPIdMateriaP1)
                .HasConstraintName("FK__Proveedor__Mater__52593CB8");

            entity.HasOne(d => d.ProveedorIdProveedor1Navigation).WithMany(p => p.ProveedorHasMateriaPs)
                .HasForeignKey(d => d.ProveedorIdProveedor1)
                .HasConstraintName("FK__Proveedor__Prove__534D60F1");
        });

        modelBuilder.Entity<Recetum>(entity =>
        {
            entity.HasKey(e => e.IdReceta).HasName("PK__Receta__7D03FC81B5DFDB38");

            entity.Property(e => e.IdReceta)
                .ValueGeneratedNever()
                .HasColumnName("idReceta");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.MateriaPIdMateriaP).HasColumnName("MateriaP_idMateriaP");
            entity.Property(e => e.ProductoIdProducto).HasColumnName("Producto_idProducto");

            entity.HasOne(d => d.MateriaPIdMateriaPNavigation).WithMany(p => p.Receta)
                .HasForeignKey(d => d.MateriaPIdMateriaP)
                .HasConstraintName("FK__Receta__MateriaP__45F365D3");

            entity.HasOne(d => d.ProductoIdProductoNavigation).WithMany(p => p.Receta)
                .HasForeignKey(d => d.ProductoIdProducto)
                .HasConstraintName("FK__Receta__Producto__46E78A0C");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__645723A695EE975D");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("idUsuario");
            entity.Property(e => e.Calle)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Colonia)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Contrasenia)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("contrasenia");
            entity.Property(e => e.Email)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("nombreUsuario");
            entity.Property(e => e.NumEx)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("num_ex");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("primerApellido");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("segundoApellido");
            entity.Property(e => e.Telefono)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<UsuarioTiendum>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioTienda).HasName("PK__UsuarioT__9AD114ED5168B0FF");

            entity.Property(e => e.IdUsuarioTienda)
                .ValueGeneratedNever()
                .HasColumnName("idUsuarioTienda");
            entity.Property(e => e.Contrasenia)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("contrasenia");
            entity.Property(e => e.Email)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("nombreUsuario");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("primerApellido");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("segundoApellido");
            entity.Property(e => e.Telefono)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.ÁreaIdÁrea).HasColumnName("Área_idÁrea");

            entity.HasOne(d => d.ÁreaIdÁreaNavigation).WithMany(p => p.UsuarioTienda)
                .HasForeignKey(d => d.ÁreaIdÁrea)
                .HasConstraintName("FK__UsuarioTi__Área___3E52440B");
        });

        modelBuilder.Entity<VentaProd>(entity =>
        {
            entity.HasKey(e => e.IdVentaProd).HasName("PK__VentaPro__5DBD9FCE209AD422");

            entity.ToTable("VentaProd");

            entity.Property(e => e.IdVentaProd)
                .ValueGeneratedNever()
                .HasColumnName("idVentaProd");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.ProductoIdProducto).HasColumnName("Producto_idProducto");
            entity.Property(e => e.SubTotal).HasColumnName("subTotal");
            entity.Property(e => e.UsuarioIdUsuario).HasColumnName("Usuario_idUsuario");
            entity.Property(e => e.UsuarioTiendaIdUsuarioTienda1).HasColumnName("UsuarioTienda_idUsuarioTienda1");

            entity.HasOne(d => d.ProductoIdProductoNavigation).WithMany(p => p.VentaProds)
                .HasForeignKey(d => d.ProductoIdProducto)
                .HasConstraintName("FK__VentaProd__Produ__5DCAEF64");

            entity.HasOne(d => d.UsuarioIdUsuarioNavigation).WithMany(p => p.VentaProds)
                .HasForeignKey(d => d.UsuarioIdUsuario)
                .HasConstraintName("FK__VentaProd__Usuar__5CD6CB2B");

            entity.HasOne(d => d.UsuarioTiendaIdUsuarioTienda1Navigation).WithMany(p => p.VentaProds)
                .HasForeignKey(d => d.UsuarioTiendaIdUsuarioTienda1)
                .HasConstraintName("FK__VentaProd__Usuar__5BE2A6F2");
        });

        modelBuilder.Entity<VentaTotal>(entity =>
        {
            entity.HasKey(e => e.IdVentaTotal).HasName("PK__VentaTot__84233CBBE3BF2E7D");

            entity.ToTable("VentaTotal");

            entity.Property(e => e.IdVentaTotal)
                .ValueGeneratedNever()
                .HasColumnName("idVentaTotal");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.VentaProdIdVentaProd).HasColumnName("VentaProd_idVentaProd");

            entity.HasOne(d => d.VentaProdIdVentaProdNavigation).WithMany(p => p.VentaTotals)
                .HasForeignKey(d => d.VentaProdIdVentaProd)
                .HasConstraintName("FK__VentaTota__Venta__60A75C0F");
        });

        modelBuilder.Entity<Área>(entity =>
        {
            entity.HasKey(e => e.IdÁrea).HasName("PK__Área__787B6F36E2D5F7D3");

            entity.ToTable("Área");

            entity.Property(e => e.IdÁrea)
                .ValueGeneratedNever()
                .HasColumnName("idÁrea");
            entity.Property(e => e.Tipo)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
