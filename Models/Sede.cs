using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mudanza1711.Models
{
    public class Sede
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int TipoSede { get; set; }
        public int IdAministrador { get; set; }
        public string Pertenece { get; set; }


    }
}
