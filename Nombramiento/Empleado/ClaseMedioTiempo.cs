using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class ClaseMedioTiempo : InterfazEmpleados
    {
        public void metodopago()
        {
            ClaseDatos.Tipo_pago = "Deposito";
        }

        public void Salario_PorHora()
        {

        }

        public static void SalarioPorMes()
        {
            ClaseDatos.SalarioPorMes = (int)((Convert.ToDouble(ClaseDatos.SalarioPorHora)) / 23.83) / 4;
        }

        public void tandaEmpleo()
        {
            ClaseDatos.Tanda = "Medio Tiempo (4Hras diarias)";
        }

        public void salario_porMes()
        {
            ClaseDatos.SalarioPorMes = (int)((Convert.ToDouble(ClaseDatos.SalarioPorHora))*4)*30;
        }
    }
}
