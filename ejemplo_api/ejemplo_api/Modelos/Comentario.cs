using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_api.Modelos
{
    public class Comentario
    {
        public int id { get; set; }
        public string texto { get; set; }
        public DateTime fechahora { get; set; }
        public Incidencias incidencia { get; set; }
        public Personal personal { get; set; }
        public string adjuntoUrl { get; set; }
    }
}
