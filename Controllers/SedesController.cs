using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mudanza1711.Models;
using Mudanza1711.Data;

namespace Mudanza1711.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SedesController : ControllerBase
    {
        ModeloSedes modelo;
        public SedesController(MvcMovieContext context)
        {
            modelo = new ModeloSedes(context);
        }

        // GET: api/Sedes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sede>>> GetSedes()
        {
            return await modelo.GetSedes().ConfigureAwait(true);
        }

        // GET: api/Sedes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<object>> GetSedes(int id)
        {
            return await modelo.getSedesAsync(id);
        }

        // PUT: api/Sedes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSedes(int id, Sede sedes)
        {
            await modelo.putSedesAsync(id, sedes);
            return NoContent();
        }

        // POST: api/Sedes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Sede>> PostSedes(Sede sedes)
        {
            await modelo.PostSedesAsync(sedes);
            return CreatedAtAction("GetSedes", new { id = sedes.Id }, sedes);
        }

        // DELETE: api/Sedes/5
        [HttpDelete("{id}")]
        public async Task<object> DeleteSedes(int id)
        {
            return await modelo.deleteSedesAsync(id);
        }
    }

}