using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mudanza1711.Models;

namespace Mudanza1711.Data
{
    public class BaseDatos
    {
        private readonly MvcMovieContext _context;

        public BaseDatos(MvcMovieContext context)
        {
            _context = context;
        }


        // CAMIONES
        // GET
        public async Task<List<Models.Camion>> GetCamionesAsync()
        {
            return await _context.Camion.ToListAsync();
        }
        // GET  /ID
        public async Task<object> GetcamionesAsync(int id)
        {
            Camion camiones = await _context.Camion.FindAsync(id);
            if (camiones == null)
            {
                return null;
            }
            return camiones;
        }
        // PUT
        public async Task PutCamionesAsync(int id, Camion camiones)
        {
            _context.Entry(camiones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
               
            }
        }

        // POST
        public async Task PostCamionesAsync(Camion camiones)
        {
            AltaCamiones registro = await _context.AltaCamiones
               .FirstOrDefaultAsync(m => m.TipoCamion == camiones.TipoCamion);
            camiones.Placas = registro.CantidadCamion + 1;
            _context.Camion.Add(camiones);
            await _context.SaveChangesAsync();

            registro.CantidadCamion++;
            _context.Entry(registro).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

            }

        }

        // DELETE
        public async Task<object> DeleteCamionesAsync(int id)
        {
            var camiones = await _context.Camion.FindAsync(id);
            if (camiones == null)
            {
                return null;
            }

            _context.Camion.Remove(camiones);
            await _context.SaveChangesAsync();

            return camiones;
        }













    }
}
