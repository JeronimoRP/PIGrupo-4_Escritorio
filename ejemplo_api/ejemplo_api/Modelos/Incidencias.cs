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
        public string adjunto_ul { get; set; }
        public string descripcion { get; set; }
        public Estado estado { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaCierre { get; set; }
        public Tipo tipo { get; set; }
        public DateTime tiempo_dec { get; set; }
        public Equipo equipo { get; set; }
        public Incidencias_subtipo incidenciasSubtipo { get; set; }
        public Personal personal1 { get; set; }
        public Personal personal2 { get; set; }

        public string archivoBase64 { get; set; }
        public string extension { get; set; }
    }
}
