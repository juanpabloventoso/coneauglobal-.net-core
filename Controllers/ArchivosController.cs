using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers
{

    //
    // Controlador de las acciones del sistema de archivos
    //
    [Route("[controller]")]
    [ApiController]
    public class ArchivosController : ControllerBase
    {

        //
        // Descarga el archivo privado ubicado en la ruta indicada 
        // Sin autenticación, validación por token y timestamp
        //
        [HttpGet]
        [Route("descargar")]
        public IActionResult Descargar(string ruta, string ts, string token)
        {
            if ((ruta == null) || (ts == null) || (token == null))
                return BadRequest();

            if (!Nucleo.Funciones.ValidarTimestamp(ts) || (!Nucleo.Funciones.ValidarToken(token, ts + ruta)))
                return Unauthorized();

            byte[] buffer = Nucleo.Archivos.Funciones.ObtenerContenido(ruta);
            return File(buffer, "application/octet-stream", System.IO.Path.GetFileName(WebUtility.UrlDecode(ruta)));
        }

        //
        // Muestra el archivo PDF privado ubicado en la ruta indicada 
        // Sin autenticación, validación por token y timestamp
        //
        [HttpGet]
        [Route("pdf")]
        public IActionResult PDF(string ruta, string ts, string token)
        {
            if ((ruta == null) || (ts == null) || (token == null))
                return BadRequest();

            if (!Nucleo.Funciones.ValidarTimestamp(ts) || (!Nucleo.Funciones.ValidarToken(token, ts + ruta)))
                return Unauthorized();

            byte[] buffer = Nucleo.Archivos.Funciones.ObtenerContenido(ruta);
            return File(buffer, "application/pdf");
        }

    }
}
