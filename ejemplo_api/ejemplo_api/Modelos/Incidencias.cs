using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_api.Modelos
{
    public enum Tipo
    {
        Equipos,
        Cuentas,
        Wifi,
        Internet,
        Software
    }
    public enum Estado
    {
        Abierta,
        Asignada,
        Enproceso,
        Enviada_A_INFORTEC,
        Resuelta,
        Cerrada
    }
    public class Incidencias
    {
        public int num { get; set; }
        public Tipo tipoIncidencia { get; set; }
        public int subtipo_id { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_cierre { get; set; }
        public string descripcion { get; set; }
        public Estado tipoEstado { get; set; }
        public string adjunto_ul { get; set; }
        public int creador_id { get; set; }
        public int responsable_id { get; set; }
        public int equipo_id { get; set; }

    }
}
