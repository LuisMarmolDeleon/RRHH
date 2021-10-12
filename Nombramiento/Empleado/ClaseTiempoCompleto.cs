using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class ClaseTiempoCompleto: InterfazEmpleados
    {
        public void metodopago()
        {
            ClaseDatos.tipo_pago = "Deposito";
        }

        public void Salario_PorHora()
        {
        }

        public void tandaEmpleo()
        {
            ClaseDatos.tanda = "Tiempo Completo (8Hras diarias)";
        }

        public void salario_porMes()
        {
            ClaseDatos.salarioPorMes = (int)((Convert.ToDouble(ClaseDatos.salarioPorHora)) * 8) * 30;
        }
    }
}
