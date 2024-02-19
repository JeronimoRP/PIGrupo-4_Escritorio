using System;

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
        public Incidencias_subtipo subtipo_id { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_cierre { get; set; }
        public string descripcion { get; set; }
        public Estado tipoEstado { get; set; }
        public string adjunto_ul { get; set; }
        public Personal personal1 { get; set; }
        public Personal personal2 { get; set; }
        public Equipo equipo_id { get; set; }
        public DateTime tiempo_dec { get; set; }

    }
}
