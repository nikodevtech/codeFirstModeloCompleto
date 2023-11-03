﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231103124948_modeloCompletoCodefirst")]
    partial class modeloCompletoCodefirst
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("gbp_operacional")
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("DAL.Acceso", b =>
                {
                    b.Property<long>("id_acceso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_acceso"));

                    b.Property<string>("codigo_acceso")
                        .HasColumnType("text");

                    b.Property<string>("descripcion_acceso")
                        .HasColumnType("text");

                    b.HasKey("id_acceso");

                    b.ToTable("accesos", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Autor", b =>
                {
                    b.Property<long>("id_autor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_autor"));

                    b.Property<string>("apellidos_autor")
                        .HasColumnType("text");

                    b.Property<string>("nombre_autor")
                        .HasColumnType("text");

                    b.HasKey("id_autor");

                    b.ToTable("autores", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Coleccion", b =>
                {
                    b.Property<long>("id_coleccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_coleccion"));

                    b.Property<string>("nombre_coleccion")
                        .HasColumnType("text");

                    b.HasKey("id_coleccion");

                    b.ToTable("colecciones", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Editorial", b =>
                {
                    b.Property<long>("id_editorial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_editorial"));

                    b.Property<string>("nombre_editorial")
                        .HasColumnType("text");

                    b.HasKey("id_editorial");

                    b.ToTable("editoriales", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.EstadoPrestamo", b =>
                {
                    b.Property<long>("id_estado_prestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_estado_prestamo"));

                    b.Property<string>("codigo_estado_prestamo")
                        .HasColumnType("text");

                    b.Property<string>("descripcion_estado_prestamo")
                        .HasColumnType("text");

                    b.HasKey("id_estado_prestamo");

                    b.ToTable("estados_prestamos", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Genero", b =>
                {
                    b.Property<long>("id_genero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_genero"));

                    b.Property<string>("descripcion_genero")
                        .HasColumnType("text");

                    b.Property<string>("nombre_genero")
                        .HasColumnType("text");

                    b.HasKey("id_genero");

                    b.ToTable("generos", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Libro", b =>
                {
                    b.Property<long>("id_libro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_libro"));

                    b.Property<long>("ColeccionId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_coleccion");

                    b.Property<long>("EditorialId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_editorial");

                    b.Property<long>("GeneroId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_genero");

                    b.Property<int?>("cantidad_libro")
                        .HasColumnType("integer");

                    b.Property<string>("edicion_libro")
                        .HasColumnType("text");

                    b.Property<string>("isbn_libro")
                        .HasColumnType("text");

                    b.Property<string>("titulo_libro")
                        .HasColumnType("text");

                    b.HasKey("id_libro");

                    b.HasIndex("ColeccionId");

                    b.HasIndex("EditorialId");

                    b.HasIndex("GeneroId");

                    b.ToTable("libros", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Prestamo", b =>
                {
                    b.Property<long>("id_prestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_prestamo"));

                    b.Property<long>("EstadoPrestamoId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_estado_prestamo");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_usuario");

                    b.Property<DateTime?>("fch_entrega_prestamo")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("fch_fin_prestamo")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("fch_inicio_prestamo")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("id_prestamo");

                    b.HasIndex("EstadoPrestamoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("prestamos", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.RelAutorLibro", b =>
                {
                    b.Property<long>("AutorId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_autor");

                    b.Property<long>("LibroId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_libro");

                    b.HasKey("AutorId", "LibroId");

                    b.HasIndex("LibroId");

                    b.ToTable("rel_autores_libros", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.RelPrestamoLibro", b =>
                {
                    b.Property<long>("PrestamoId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_prestamo");

                    b.Property<long>("LibroId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_libro");

                    b.HasKey("PrestamoId", "LibroId");

                    b.HasIndex("LibroId");

                    b.ToTable("rel_prestamos_libros", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Usuario", b =>
                {
                    b.Property<long>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_usuario"));

                    b.Property<long>("AccesoId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_acceso");

                    b.Property<string>("apellidos_usuario")
                        .HasColumnType("text");

                    b.Property<string>("clave_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dni_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email_usuario")
                        .HasColumnType("text");

                    b.Property<bool?>("estaBloqueado_usuario")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("fch_alta_usuario")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("fch_baja_usuario")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("fch_fin_bloqueo_usuario")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("nombre_usuario")
                        .HasColumnType("text");

                    b.Property<string>("tlf_usuario")
                        .HasColumnType("text");

                    b.HasKey("id_usuario");

                    b.HasIndex("AccesoId");

                    b.ToTable("usuarios", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Libro", b =>
                {
                    b.HasOne("DAL.Coleccion", "Coleccion")
                        .WithMany("Libros")
                        .HasForeignKey("ColeccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Editorial", "Editorial")
                        .WithMany("Libros")
                        .HasForeignKey("EditorialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Genero", "Genero")
                        .WithMany("Libros")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coleccion");

                    b.Navigation("Editorial");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("DAL.Prestamo", b =>
                {
                    b.HasOne("DAL.EstadoPrestamo", "EstadoPrestamo")
                        .WithMany("Prestamos")
                        .HasForeignKey("EstadoPrestamoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Usuario", "Usuario")
                        .WithMany("Prestamos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoPrestamo");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("DAL.RelAutorLibro", b =>
                {
                    b.HasOne("DAL.Autor", "Autor")
                        .WithMany("RelAutorLibros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Libro", "Libro")
                        .WithMany("RelAutorLibros")
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("DAL.RelPrestamoLibro", b =>
                {
                    b.HasOne("DAL.Libro", "Libro")
                        .WithMany("RelPrestamoLibros")
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Prestamo", "Prestamo")
                        .WithMany("RelPrestamoLibros")
                        .HasForeignKey("PrestamoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Libro");

                    b.Navigation("Prestamo");
                });

            modelBuilder.Entity("DAL.Usuario", b =>
                {
                    b.HasOne("DAL.Acceso", "Acceso")
                        .WithMany("Usuarios")
                        .HasForeignKey("AccesoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acceso");
                });

            modelBuilder.Entity("DAL.Acceso", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("DAL.Autor", b =>
                {
                    b.Navigation("RelAutorLibros");
                });

            modelBuilder.Entity("DAL.Coleccion", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("DAL.Editorial", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("DAL.EstadoPrestamo", b =>
                {
                    b.Navigation("Prestamos");
                });

            modelBuilder.Entity("DAL.Genero", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("DAL.Libro", b =>
                {
                    b.Navigation("RelAutorLibros");

                    b.Navigation("RelPrestamoLibros");
                });

            modelBuilder.Entity("DAL.Prestamo", b =>
                {
                    b.Navigation("RelPrestamoLibros");
                });

            modelBuilder.Entity("DAL.Usuario", b =>
                {
                    b.Navigation("Prestamos");
                });
#pragma warning restore 612, 618
        }
    }
}
