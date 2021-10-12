using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class Print
    {
        //se imprimen los datos
        public static void Printer()
        {
            TextWriter txtw;
            
            //El documento se creara con el nombre y el estado laboral
            txtw = new StreamWriter(ClaseDatos.NombreCompleto_empleado+ClaseDatos.estado_laboral+".txt");

            txtw.Write("Datos de empleado:\n\n");
            txtw.Write("Cedula de identidad: " + ClaseDatos.cedula + "\n");
            txtw.Write("Nombre completo: " + ClaseDatos.NombreCompleto_empleado+"\n");
            txtw.Write("Tanda laboral: " + ClaseDatos.tanda+"\n");
            txtw.Write("Metodo de pago: " + ClaseDatos.tipo_pago + "\n");
            if (ClaseDatos.cuenta !=0) {
            txtw.Write("Cuenta bancaria: " + ClaseDatos.cuenta + "\n");
            }
            txtw.Write("Salario por hora: " + ClaseDatos.salarioPorHora + "\n");
            txtw.Write("Salario por mes: " + ClaseDatos.salarioPorMes + "\n");
            txtw.Write("Estado laboral: " + ClaseDatos.estado_laboral + "\n");

            //Determinar el estado laboral del empleado
            if (ClaseDatos.estado_laboral == "Vacaciones" || ClaseDatos.estado_laboral== "Permiso") {
                txtw.Write("Desde: " + ClaseDatos.fecha_inicio + "\n");
                txtw.Write("Hasta: " + ClaseDatos.fecha_hasta + "\n");
            }else if(ClaseDatos.estado_laboral== "Desvinculado")
            {
                txtw.Write("Motivo de desvinculacion: " + ClaseDatos.motivoDesvinculado + "\n");
            }
            //Cierre documento
            txtw.Close();
            Extras.Volver();


         }
        }
    }

