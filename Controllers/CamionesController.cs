using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mudanza1711.Data;
using Mudanza1711.Models;

namespace Mudanza1711.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamionesController : ControllerBase
    {
        Modelo modelo;
        public CamionesController(MvcMovieContext context)
        {
            modelo = new Modelo(context);
        }

        // GET: api/Camiones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Camion>>> GetCamiones()
        {
            return await modelo.GetCamiones().ConfigureAwait(true);
        }

        // GET: api/Camiones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<object>> GetCamiones(int id)
        {
            return await modelo.getCamionesAsync(id);
        }

        // PUT: api/Camiones/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCamiones(int id, Camion camiones)
        {
            await modelo.putCamionesAsync(id, camiones);
            return NoContent();
        }

        // POST: api/Camiones
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Camion>> PostCamiones(Camion camiones)
        {
            await modelo.PostCamionesAsync(camiones);
            return CreatedAtAction("GetCamiones", new { id = camiones.Id }, camiones);
        }

        // DELETE: api/Camiones/5
        [HttpDelete("{id}")]
        public async Task<object> DeleteCamiones(int id)
        {
            return await modelo.deleteCamionesAsync(id);
        } 
    }
}
