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
            ClaseDatos.Tipo_pago = "Deposito";
        }

        public void Salario_PorHora()
        {
        }

        public void tandaEmpleo()
        {
            ClaseDatos.Tanda = "Tiempo Completo (8Hras diarias)";
        }

        public void salario_porMes()
        {
            ClaseDatos.SalarioPorMes = (int)((Convert.ToDouble(ClaseDatos.SalarioPorHora)) * 8) * 30;
        }
    }
}
