using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_api.Modelos
{
    public enum tipo_equipo
    {
        Altavoces,
        Impresora,
        Monitor,
        Pantalla_interactiva,
        Portátil_de_aula,
        Portátil_consejería,
        Proyector,
    }

    public class Equipo
    {
        public int id { get; set; }
        public byte baja { get; set; }
        public string descripcion { get; set; }
        public string etiqueta { get; set; }
        public DateTime fecha_adquisicion { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int puesto { get; set; }
        public tipo_equipo tipoEquipo { get; set; }
        
        public Aula aula { get; set; }
        
    }
}
