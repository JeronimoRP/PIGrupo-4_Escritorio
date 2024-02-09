
using ejemplo_api.Controles;
using ejemplo_api.Formularios;
using ejemplo_api.ListaDeClases;
using ejemplo_api.Modelos;
using System;
using System.Windows.Forms;

namespace ejemplo_api
{
    internal static class Program
    {
        static Controlador_Perfiles control;
        static Lista_Perfiles listaPerfiles;
        static Perfiles perfiles;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            control = new Controlador_Perfiles();
            perfiles = new Perfiles();
            listaPerfiles = new Lista_Perfiles();
            perfil();

            if (perfiles == null)
            {
                MessageBox.Show("No posees las credenciales necesaria para poder utilizar la aplicacion");
            }
            else if (profAdmniONo()==true)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Administrador());

            }
            else if (profAdmniONo() == false)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
               // Application.Run(new Profesor());
            }
        }

        private static async void perfil()
        {
            Perfiles p = await control.GetPerfil(recogerCredencialesporDominio());
            perfiles.personal_id = p.personal_id;
            perfiles.dominio = p.dominio;
            perfiles.educantabria = p.educantabria;
            perfiles.password = p.password;
            perfiles.tipoPerfil = p.tipoPerfil;
        }

        private static bool profAdmniONo()
        {
            bool profesor = false;
            if (perfiles.tipoPerfil.Equals(Perfil.Administrador))
            {
                profesor = true;
            }
            return profesor;
        }
        private static string recogerCredencialesporDominio()
        {
            var userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] aux = userName.Split('\\');
            string nombreDelUsuario = aux[aux.Length - 1];
            return nombreDelUsuario;
        }

    }
}
    

