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

        public static string estado_laboral { get; set; }

        public static string fecha_inicio { get; set; }

        public static string fecha_hasta { get; set; }

        public static string motivoDesvinculado { get; set; }

        public static string cedula { get; set; }
        public static string tipo_pago { get; set; }

        public static string tanda { get; set; }
        public static int salarioPorHora { get; internal set; }

        public static int salarioPorMes { get; internal set; }

        public static int cuenta { get; set; }
    }
}
