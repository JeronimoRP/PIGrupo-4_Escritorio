using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_api.Modelos
{

    public enum PC
    {
        ORDENADOR,
        RATÓN,
        TECLADO
    }

    public enum Portatil
    {
        PROPORCIONADO_POR_CONSEJERÍA,
        DE_AULA
    }

    public enum Yedra
    {
        GESTIONA_J_EST
    }

    public class Incidencias_subtipo
    {
        public int id { get; set; }
        public string subSubtipo { get; set; }
        public string subtipoNombre { get; set; }
        public Tipo tipo { get; set; }
    }
}
