using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class modeloCompletoCodefirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "gbp_operacional");

            migrationBuilder.CreateTable(
                name: "accesos",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_acceso = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    codigo_acceso = table.Column<string>(type: "text", nullable: true),
                    descripcion_acceso = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accesos", x => x.id_acceso);
                });

            migrationBuilder.CreateTable(
                name: "autores",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_autor = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_autor = table.Column<string>(type: "text", nullable: true),
                    apellidos_autor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autores", x => x.id_autor);
                });

            migrationBuilder.CreateTable(
                name: "colecciones",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_coleccion = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_coleccion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colecciones", x => x.id_coleccion);
                });

            migrationBuilder.CreateTable(
                name: "editoriales",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_editorial = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_editorial = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_editoriales", x => x.id_editorial);
                });

            migrationBuilder.CreateTable(
                name: "estados_prestamos",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_estado_prestamo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    codigo_estado_prestamo = table.Column<string>(type: "text", nullable: true),
                    descripcion_estado_prestamo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estados_prestamos", x => x.id_estado_prestamo);
                });

            migrationBuilder.CreateTable(
                name: "generos",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_genero = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_genero = table.Column<string>(type: "text", nullable: true),
                    descripcion_genero = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generos", x => x.id_genero);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_usuario = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    dni_usuario = table.Column<string>(type: "text", nullable: false),
                    nombre_usuario = table.Column<string>(type: "text", nullable: true),
                    apellidos_usuario = table.Column<string>(type: "text", nullable: true),
                    tlf_usuario = table.Column<string>(type: "text", nullable: true),
                    email_usuario = table.Column<string>(type: "text", nullable: true),
                    clave_usuario = table.Column<string>(type: "text", nullable: false),
                    estaBloqueado_usuario = table.Column<bool>(type: "boolean", nullable: true),
                    fch_fin_bloqueo_usuario = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    fch_alta_usuario = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    fch_baja_usuario = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    id_acceso = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id_usuario);
                    table.ForeignKey(
                        name: "FK_usuarios_accesos_id_acceso",
                        column: x => x.id_acceso,
                        principalSchema: "gbp_operacional",
                        principalTable: "accesos",
                        principalColumn: "id_acceso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "libros",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_libro = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    isbn_libro = table.Column<string>(type: "text", nullable: true),
                    titulo_libro = table.Column<string>(type: "text", nullable: true),
                    edicion_libro = table.Column<string>(type: "text", nullable: true),
                    cantidad_libro = table.Column<int>(type: "integer", nullable: true),
                    id_editorial = table.Column<long>(type: "bigint", nullable: false),
                    id_genero = table.Column<long>(type: "bigint", nullable: false),
                    id_coleccion = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libros", x => x.id_libro);
                    table.ForeignKey(
                        name: "FK_libros_colecciones_id_coleccion",
                        column: x => x.id_coleccion,
                        principalSchema: "gbp_operacional",
                        principalTable: "colecciones",
                        principalColumn: "id_coleccion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_libros_editoriales_id_editorial",
                        column: x => x.id_editorial,
                        principalSchema: "gbp_operacional",
                        principalTable: "editoriales",
                        principalColumn: "id_editorial",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_libros_generos_id_genero",
                        column: x => x.id_genero,
                        principalSchema: "gbp_operacional",
                        principalTable: "generos",
                        principalColumn: "id_genero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prestamos",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_prestamo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    fch_inicio_prestamo = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    fch_fin_prestamo = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    fch_entrega_prestamo = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    id_estado_prestamo = table.Column<long>(type: "bigint", nullable: false),
                    id_usuario = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamos", x => x.id_prestamo);
                    table.ForeignKey(
                        name: "FK_prestamos_estados_prestamos_id_estado_prestamo",
                        column: x => x.id_estado_prestamo,
                        principalSchema: "gbp_operacional",
                        principalTable: "estados_prestamos",
                        principalColumn: "id_estado_prestamo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prestamos_usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalSchema: "gbp_operacional",
                        principalTable: "usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rel_autores_libros",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_autor = table.Column<long>(type: "bigint", nullable: false),
                    id_libro = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rel_autores_libros", x => new { x.id_autor, x.id_libro });
                    table.ForeignKey(
                        name: "FK_rel_autores_libros_autores_id_autor",
                        column: x => x.id_autor,
                        principalSchema: "gbp_operacional",
                        principalTable: "autores",
                        principalColumn: "id_autor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rel_autores_libros_libros_id_libro",
                        column: x => x.id_libro,
                        principalSchema: "gbp_operacional",
                        principalTable: "libros",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rel_prestamos_libros",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_prestamo = table.Column<long>(type: "bigint", nullable: false),
                    id_libro = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rel_prestamos_libros", x => new { x.id_prestamo, x.id_libro });
                    table.ForeignKey(
                        name: "FK_rel_prestamos_libros_libros_id_libro",
                        column: x => x.id_libro,
                        principalSchema: "gbp_operacional",
                        principalTable: "libros",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rel_prestamos_libros_prestamos_id_prestamo",
                        column: x => x.id_prestamo,
                        principalSchema: "gbp_operacional",
                        principalTable: "prestamos",
                        principalColumn: "id_prestamo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_libros_id_coleccion",
                schema: "gbp_operacional",
                table: "libros",
                column: "id_coleccion");

            migrationBuilder.CreateIndex(
                name: "IX_libros_id_editorial",
                schema: "gbp_operacional",
                table: "libros",
                column: "id_editorial");

            migrationBuilder.CreateIndex(
                name: "IX_libros_id_genero",
                schema: "gbp_operacional",
                table: "libros",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_id_estado_prestamo",
                schema: "gbp_operacional",
                table: "prestamos",
                column: "id_estado_prestamo");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_id_usuario",
                schema: "gbp_operacional",
                table: "prestamos",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_rel_autores_libros_id_libro",
                schema: "gbp_operacional",
                table: "rel_autores_libros",
                column: "id_libro");

            migrationBuilder.CreateIndex(
                name: "IX_rel_prestamos_libros_id_libro",
                schema: "gbp_operacional",
                table: "rel_prestamos_libros",
                column: "id_libro");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_id_acceso",
                schema: "gbp_operacional",
                table: "usuarios",
                column: "id_acceso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rel_autores_libros",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "rel_prestamos_libros",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "autores",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "libros",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "prestamos",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "colecciones",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "editoriales",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "generos",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "estados_prestamos",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "usuarios",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "accesos",
                schema: "gbp_operacional");
        }
    }
}
