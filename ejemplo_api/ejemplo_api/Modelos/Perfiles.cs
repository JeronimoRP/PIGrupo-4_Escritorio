using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_api.Modelos
{
    public class Perfiles
    {
        public int personalId { get; set; }
        public string dominio { get; set; }
        public string educantabria { get; set; }
        public string password { get; set; }
        public Perfil tipoPerfil { get; set; }

    }
    public enum Perfil
    {
        Administrador,
        Profesor
    }
}
