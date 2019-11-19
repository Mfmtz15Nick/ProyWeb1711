using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mudanza1711.Models;

namespace Mudanza1711.Data
{
    public class BaseDatosSedes
    {
        private readonly MvcMovieContext _context;

        public BaseDatosSedes(MvcMovieContext context)
        {
            _context = context;
        }


        // SEDES
        // GET
        public async Task<List<Sede>> GetSedesAsync()
        {
            return await _context.Sede.ToListAsync();
        }
        // GET  /ID
        public async Task<object> GetsedesAsync(int id)
        {
            Sede sedes = await _context.Sede.FindAsync(id);
            if (sedes == null)
            {
                return null;
            }
            return sedes;
        }
        // PUT
        public async Task PutSedesAsync(int id, Sede sedes)
        {
            _context.Entry(sedes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

            }
        }

        // POST
        public async Task PostSedesAsync(Sede sedes)
        {
            _context.Sede.Add(sedes);
            await _context.SaveChangesAsync();

            

        }

        // DELETE
        public async Task<object> DeleteSedesAsync(int id)
        {
            var sedes = await _context.Sede.FindAsync(id);
            if (sedes == null)
            {
                return null;
            }

            _context.Sede.Remove(sedes);
            await _context.SaveChangesAsync();

            return sedes;
        }


    }
}
