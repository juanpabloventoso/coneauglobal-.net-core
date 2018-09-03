using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{
    //
    // Controlador de las acciones de usuarios
    //
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        //
        // Devuelve la URL relativa del avatar para el nombre de usuario especificado
        //
        [HttpGet]
        [Route("avatar")]
        public IActionResult Avatar(string usuario)
        {
            if (usuario == null)
                return BadRequest();

            // Preparar la URL y la ruta del sistema de archivos
            string avatar = $"/coneauglobal/recursos/imagenes/usuarios/{usuario}.jpg";
            string file = Nucleo.Archivos.Funciones.RutaPublica() + avatar.Replace('/', '\\');

            // Devolver el avatar con el timestamp si existe
            if (System.IO.File.Exists(file))
            {
                DateTime dt = System.IO.File.GetLastWriteTime(file);
                return Ok(avatar + "?ts=" + dt.Ticks.ToString());
            }

            // Devolver el avatar por defecto
            return Ok("/coneauglobal/recursos/imagenes/iconos/perfil-vacio.png");
        }

    }
}
