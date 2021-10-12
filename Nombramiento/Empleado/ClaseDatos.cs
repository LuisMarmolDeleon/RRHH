using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class ClaseDatos
    {
        public static string NombreCompleto_empleado { get; set; }

        public static string Estado_laboral { get; set; }

        public static string Fecha_inicio { get; set; }

        public static string Fecha_hasta { get; set; }

        public static string MotivoDesvinculado { get; set; }

        public static string Cedula { get; set; }
        public static string Tipo_pago { get; set; }

        public static string Tanda { get; set; }
        public static int SalarioPorHora { get; internal set; }

        public static int SalarioPorMes { get; internal set; }

        public static int Cuenta { get; set; }
    }
}
