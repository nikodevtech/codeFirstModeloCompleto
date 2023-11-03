using CodeFirstModeloCompleto.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace CodeFirstModeloCompleto.Controllers
{
    public class HomeController : Controller
    {
        private readonly Contexto _modeloVirtual;
        public HomeController(Contexto modeloVirtual)
        {
            _modeloVirtual = modeloVirtual;
        }

        public IActionResult Index()
        {
            // Pruebas del modelo virtual

            //Insert
            Acceso acceso = new Acceso("Acceso prueba", "probando el insert");
            _modeloVirtual.Accesos.Add(acceso);

            Usuario usuario = new Usuario("33224433W", "noName", "noLastName", "4343242", "noemail@no.com", "dadwad2", false, null, null, null, 1);
            _modeloVirtual.Usuarios.Add(usuario);

            Genero genero = new Genero("Terror", "Libros de terror");
            _modeloVirtual.Generos.Add(genero);

            Editorial editorial = new Editorial("Planeta Agostini");
            _modeloVirtual.Editoriales.Add(editorial);

            Coleccion coleccion = new Coleccion("Coleccion prueba");
            _modeloVirtual.Colecciones.Add(coleccion);

            Libro libro = new Libro("321321", "Dracula", "Ralv", 3, 1, 1, 1);
            _modeloVirtual.Libros.Add(libro);

            Autor autor = new Autor("NombreAutor", "ApellidosAutor");
            _modeloVirtual.Autores.Add(autor);

            EstadoPrestamo estadoPrestamo = new EstadoPrestamo("Devuelto", "El prestamo ha sido devuelto en tiempo");
            _modeloVirtual.EstadoPrestamos.Add(estadoPrestamo);

            Prestamo prestamo = new Prestamo(null, null, null, 1, 1);
            _modeloVirtual.Prestamos.Add(prestamo);

            RelAutorLibro relAutorLibro = new RelAutorLibro(1, 1);
            _modeloVirtual.RelAutorLibros.Add(relAutorLibro);

            RelPrestamoLibro relPrestamoLibro = new RelPrestamoLibro(1, 1);
            _modeloVirtual.RelPrestamoLibros.Add(relPrestamoLibro);

            // Guardar los cambios en la base de datos (equivalente a commit en java)
            _modeloVirtual.SaveChanges();

            // Select
            List<Usuario> listaUsuarios = _modeloVirtual.Usuarios.ToList();
            foreach (Usuario user in listaUsuarios)
            {
                user.MostrarDatosUsuario();
            }

            return View();
        }

    }
}