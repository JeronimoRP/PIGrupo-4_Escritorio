using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_api.Modelos
{
    public class Departamento
    {
        public int jefe_dep { get; set; }
        public string cod { get; set; }
        public string nombre { get; set; }
        public int activo { get; set; }
    }
}
