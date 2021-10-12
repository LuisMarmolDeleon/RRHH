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
            ClaseDatos.tipo_pago = "Deposito";
        }

        public void Salario_PorHora()
        {

        }

        public void salarioPorMes()
        {
            ClaseDatos.salarioPorMes = (int)((Convert.ToDouble(ClaseDatos.salarioPorHora)) / 23.83) / 4;
        }

        public void tandaEmpleo()
        {
            ClaseDatos.tanda = "Medio Tiempo (4Hras diarias)";
        }

        public void salario_porMes()
        {
            ClaseDatos.salarioPorMes = (int)((Convert.ToDouble(ClaseDatos.salarioPorHora))*4)*30;
        }
    }
}
