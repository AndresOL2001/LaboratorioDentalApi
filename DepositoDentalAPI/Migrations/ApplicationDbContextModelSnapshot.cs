﻿// <auto-generated />
using System;
using DepositoDentalAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DepositoDentalAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepositoDentalAPI.Entity.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.CategoriaProducto", b =>
                {
                    b.Property<int>("categoriaId")
                        .HasColumnType("int");

                    b.Property<int>("productoId")
                        .HasColumnType("int");

                    b.HasKey("categoriaId", "productoId");

                    b.HasIndex("productoId");

                    b.ToTable("categoriaProductos");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.DetalleOrden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("OrdenId")
                        .HasColumnType("int");

                    b.Property<double>("PrecioUnitario")
                        .HasColumnType("float");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId");

                    b.HasIndex("ProductoId");

                    b.ToTable("detallesOrden");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DireccionEntrega")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaPedido")
                        .HasColumnType("datetime2");

                    b.Property<double>("GranTotal")
                        .HasColumnType("float");

                    b.Property<string>("Notas")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("ordenes");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CantidadEnStock")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("ProductoNombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("productos");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RFC")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("celular")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.CategoriaProducto", b =>
                {
                    b.HasOne("DepositoDentalAPI.Entity.Categoria", "categoria")
                        .WithMany("categoriaProductos")
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DepositoDentalAPI.Entity.Producto", "producto")
                        .WithMany("categoriaProductos")
                        .HasForeignKey("productoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoria");

                    b.Navigation("producto");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.DetalleOrden", b =>
                {
                    b.HasOne("DepositoDentalAPI.Entity.Orden", "orden")
                        .WithMany()
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DepositoDentalAPI.Entity.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("orden");

                    b.Navigation("producto");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.Orden", b =>
                {
                    b.HasOne("DepositoDentalAPI.Entity.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.Usuario", b =>
                {
                    b.HasOne("DepositoDentalAPI.Entity.Rol", "rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("rol");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.Categoria", b =>
                {
                    b.Navigation("categoriaProductos");
                });

            modelBuilder.Entity("DepositoDentalAPI.Entity.Producto", b =>
                {
                    b.Navigation("categoriaProductos");
                });
#pragma warning restore 612, 618
        }
    }
}