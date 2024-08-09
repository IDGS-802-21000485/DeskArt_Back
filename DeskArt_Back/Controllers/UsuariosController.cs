//using DeskArt_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DeskArt_Back.Controllers
{
    public class UsuariosController : Controller
    {/*
        //Creamos la variable de contexto
        private readonly DeskArtContext _baseDatos;

        public UsuariosController(DeskArtContext baseDatos)
        {
            _baseDatos = baseDatos;
        }

        //Metodo Get Usuarios que devuelve la lista de todas las tareas en la db
        [HttpGet]
        [Route("GetUsuarios")]
        public async Task<IActionResult> Lista()
        {
            var listaConsola = await _baseDatos.LoginMobils.ToListAsync();
            return Ok(listaConsola);
        }

        [HttpPost]
        [Route("/api/login")]
        public async Task<IActionResult> BuscarPorEmail([FromBody] LoginMobil usuarioL)
        {
            // Validación de email no vacío
            if (string.IsNullOrWhiteSpace(usuarioL.Email))
            {
                return BadRequest("El email no puede estar vacío.");
            }

            // Validación de formato de email
            if (!IsValidEmail(usuarioL.Email))
            {
                return BadRequest("El formato del email no es válido.");
            }

            // Validación de contraseña no vacía
            if (string.IsNullOrWhiteSpace(usuarioL.Contrasena))
            {
                return BadRequest("La contraseña no puede estar vacía.");
            }

            var usuario = await _baseDatos.LoginMobils.FirstOrDefaultAsync(u => u.Email == usuarioL.Email);

            if (usuario == null)
            {
                return NotFound("No se encontró un usuario con el email proporcionado.");
            }

            // Validación de la contraseña
            if (usuario.Contrasena != usuarioL.Contrasena)
            {
                return Unauthorized("La contraseña es incorrecta.");
            }

            return Ok(usuario);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        [HttpPost]
        [Route("/api/registrar")]
        public async Task<IActionResult> RegistrarUsuario([FromBody] LoginMobil usuarioL)
        {
            // Validación de email no vacío
            if (string.IsNullOrWhiteSpace(usuarioL.Email))
            {
                return BadRequest("El email no puede estar vacío.");
            }

            // Validación de formato de email
            if (!IsValidEmail(usuarioL.Email))
            {
                return BadRequest("El formato del email no es válido.");
            }

            // Validación de contraseña no vacía
            if (string.IsNullOrWhiteSpace(usuarioL.Contrasena))
            {
                return BadRequest("La contraseña no puede estar vacía.");
            }

            // Validación de nombre no vacío
            if (string.IsNullOrWhiteSpace(usuarioL.Nombre))
            {
                return BadRequest("El nombre no puede estar vacío.");
            }

            // Agregar el usuario a la base de datos
            await _baseDatos.AddAsync(usuarioL);
            await _baseDatos.SaveChangesAsync();

            return Ok($"Se agregó el usuario: {usuarioL.Nombre} exitosamente");
        }

        [HttpPut]
        [Route("/api/actualizar")]
        public async Task<IActionResult> ActualizarUsuario([FromBody] LoginMobil usuarioL)
        {
            // Validación de ID no vacío
            if (usuarioL.Id == 0)
            {
                return BadRequest("El ID del usuario es necesario para actualizar.");
            }

            // Validación de email no vacío
            if (string.IsNullOrWhiteSpace(usuarioL.Email))
            {
                return BadRequest("El email no puede estar vacío.");
            }

            // Validación de formato de email
            if (!IsValidEmail(usuarioL.Email))
            {
                return BadRequest("El formato del email no es válido.");
            }

            // Validación de contraseña no vacía
            if (string.IsNullOrWhiteSpace(usuarioL.Contrasena))
            {
                return BadRequest("La contraseña no puede estar vacía.");
            }

            // Validación de nombre no vacío
            if (string.IsNullOrWhiteSpace(usuarioL.Nombre))
            {
                return BadRequest("El nombre no puede estar vacío.");
            }

            // Buscar el usuario en la base de datos por ID
            var usuarioExistente = await _baseDatos.LoginMobils.FindAsync(usuarioL.Id);

            if (usuarioExistente == null)
            {
                return NotFound("El usuario no existe.");
            }

            // Actualizar los datos del usuario
            usuarioExistente.Email = usuarioL.Email;
            usuarioExistente.Contrasena = usuarioL.Contrasena;
            usuarioExistente.Nombre = usuarioL.Nombre;

            // Guardar los cambios en la base de datos
            _baseDatos.LoginMobils.Update(usuarioExistente);
            await _baseDatos.SaveChangesAsync();

            return Ok($"Se actualizó el usuario: {usuarioL.Nombre} exitosamente");
        }*/
    }
}
