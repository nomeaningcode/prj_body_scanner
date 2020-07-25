using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBodyScanner.Cache
{
    public static class UserLoginCache
    {
        public static int IIDoctor { get; set; }
        public static string Matricula { get; set; }
        public static string Nombre { get; set; }
        public static string ApellidoP { get; set; }
        public static string ApellidoM { get; set; }
        public static string Telefono { get; set; }
        public static string Correo { get; set; }
        public static string Direccion { get; set; }
        public static bool AccionCerrar { get; set; }
    }
}
