using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_api.Modelos
{
    public enum tipo_equipo
    {
        Ordenadores,
        pantallas,
        proyectores
    }

    public class Equipo
    {
        public int id { get; set; }
        public tipo_equipo tipoEquipo { get; set; }
        public DateTime fecha_adquisicion { get; set; }
        public string etiqueta { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string descripcion { get; set; }
        public int baja { get; set; }
        public int aula_num { get; set; }
        public int puesto { get; set; }
    }
}
