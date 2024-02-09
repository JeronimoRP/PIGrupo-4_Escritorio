using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_api.Modelos
{
    public enum Subtipo
    {
        PC, 
        Impresora, 
        Proyector
    }
    public class Incidencias_subtipo
    {
        public int id { get; set; }
        public Subtipo subtipoIncidencias { get; set; }
        public string subtipo_nombre { get; set; }
        public string sub_subtipo { get; set; }
    }
}
