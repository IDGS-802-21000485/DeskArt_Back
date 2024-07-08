using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using DeskArt_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace DeskArt_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        //Creamos la variable de contexto
        private readonly DeskArtContext _baseDatos;

        public ProductosController(DeskArtContext baseDatos)
        {
            _baseDatos = baseDatos;
        }

        //Metodo Get ListaTareas que devuelve la lista de todas las tareas en la db
        [HttpGet]
        [Route("GetProductos")]
        public async Task<IActionResult> Lista()
        {
            var listaConsola = await _baseDatos.Productos.ToListAsync();
            return Ok(listaConsola);
        }
    }
}
