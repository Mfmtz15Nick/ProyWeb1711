using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mudanza1711.Models
{
    public class Camion
    {
        public int Id { get; set; }
        public string TipoCamion { get; set; }
        public string TipoCombustible { get; set; }
        public int Placas { get; set; }
        public int CapacidadPeso { get; set; }
        public int Volumen { get; set; }
        public int Kilometraje { get; set; }
        public int KilometrajeUltimoServicio { get; set; }


    }
}
