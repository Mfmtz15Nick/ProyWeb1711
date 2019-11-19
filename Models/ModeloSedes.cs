using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mudanza1711.Models;
using Mudanza1711.Data;

namespace Mudanza1711.Models
{
    public class ModeloSedes
    {
        private BaseDatosSedes bd;

        public ModeloSedes(MvcMovieContext context)
        {
            bd = new BaseDatosSedes(context);
        }

        // SEDES
        // GET
        public Task<List<Sede>> GetSedes()
        {
            return bd.GetSedesAsync();
        }
        // GET / ID
        public async Task<object> getSedesAsync(int id)
        {
            return await bd.GetsedesAsync(id);
        }
        public async Task putSedesAsync(int id, Sede sedes)
        {
            await bd.PutSedesAsync(id, sedes);
        }
        // POST 
        public async Task PostSedesAsync(Sede sedes)
        {
            await bd.PostSedesAsync(sedes);
        }
        // DELETE
        public async Task<object> deleteSedesAsync(int id)
        {
            return await bd.DeleteSedesAsync(id);
        }





    }
}
