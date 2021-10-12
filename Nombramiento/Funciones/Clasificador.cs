using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    //Se obtiene la tanda y luego se establece su periodo laboral
    class Clasificador
    {
        public static InterfazEmpleados Getter(int tanda)
        {
            if (tanda == 1)
            {
                return new ClaseTiempoCompleto();
            }
            else if (tanda == 2)
            {
                return new ClaseMedioTiempo();
            }
            else { return new ClaseTemporal(); }
        }
    }
}
