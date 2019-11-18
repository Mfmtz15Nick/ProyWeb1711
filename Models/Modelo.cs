using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mudanza1711.Data;
using Mudanza1711.Models;

namespace Mudanza1711.Models
{
    public class Modelo
    {
        private BaseDatos bd;

        public Modelo(MvcMovieContext context)
        {
            bd = new BaseDatos(context);
        }

        // CAMIONES
        // GET
        public Task<List<Camion>> GetCamiones()
        {
            return bd.GetCamionesAsync();
        }
        // GET / ID
        public async Task<object> getCamionesAsync(int id)
        {
            return await bd.GetcamionesAsync(id);
        }
        public async Task putCamionesAsync(int id, Camion camiones)
        {
            await bd.PutCamionesAsync(id, camiones);
        }
        // POST 
        public async Task PostCamionesAsync(Camion camiones)
        {
            await bd.PostCamionesAsync(camiones);
        }
        // DELETE
        public async Task<object> deleteCamionesAsync(int id)
        {
            return await bd.DeleteCamionesAsync(id);
        }





    }
}
