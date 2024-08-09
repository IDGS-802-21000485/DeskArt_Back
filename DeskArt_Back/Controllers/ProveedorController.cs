using Microsoft.AspNetCore.Mvc;
using DeskArt_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace DeskArt_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        // Creamos la variable de contexto
        private readonly DeskArtContext _baseDatos;

        public ProveedorController(DeskArtContext baseDatos)
        {
            _baseDatos = baseDatos;
        }

        // Método Get que devuelve la lista de todos los proveedores
        [HttpGet]
        [Route("GetProveedores")]
        public async Task<IActionResult> Lista()
        {
            var listaProveedores = await _baseDatos.Proveedors.ToListAsync();
            return Ok(listaProveedores);
        }

        // Método Get que devuelve un proveedor por su ID
        [HttpGet]
        [Route("GetProveedor/{id}")]
        public async Task<IActionResult> ObtenerProveedor(int id)
        {
            var proveedor = await _baseDatos.Proveedors.FindAsync(id);
            if (proveedor == null)
            {
                return NotFound();
            }
            return Ok(proveedor);
        }

        // Método Post que crea un nuevo proveedor
        [HttpPost]
        [Route("CrearProveedor")]
        public async Task<IActionResult> Crear(Proveedor proveedor)
        {
            _baseDatos.Proveedors.Add(proveedor);
            await _baseDatos.SaveChangesAsync();
            return CreatedAtAction(nameof(ObtenerProveedor), new { id = proveedor.IdProveedor }, proveedor);
        }

        // Método Put que actualiza un proveedor existente
        [HttpPut]
        [Route("ActualizarProveedor/{id}")]
        public async Task<IActionResult> Actualizar(int id, Proveedor proveedorActualizado)
        {
            if (id != proveedorActualizado.IdProveedor)
            {
                return BadRequest();
            }

            _baseDatos.Entry(proveedorActualizado).State = EntityState.Modified;

            try
            {
                await _baseDatos.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProveedorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // Método Delete que elimina un proveedor por su ID
        [HttpDelete]
        [Route("EliminarProveedor/{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var proveedor = await _baseDatos.Proveedors.FindAsync(id);
            if (proveedor == null)
            {
                return NotFound();
            }

            _baseDatos.Proveedors.Remove(proveedor);
            await _baseDatos.SaveChangesAsync();

            return NoContent();
        }

        private bool ProveedorExists(int id)
        {
            return _baseDatos.Proveedors.Any(e => e.IdProveedor == id);
        }
    }
}
