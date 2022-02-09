using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Operaciones
{
    public class CalSueldo
    {
        public float peso1 { get; set; }
        public float peso2 { get; set; }
        public float peso3 { get; set; }
        public float salariominimo { get; set; }

        public CalSueldo(Configuracion configuracion)
        {
            this.peso1 = configuracion.Salario_Horas_Extras;
            this.peso2 = configuracion.Horas_Extras_Minima;
            this.peso3 = configuracion.Horas_Extras_Maxima;
            this.salariominimo = configuracion.sueldoMaximo;
        }

        public float salario(Salario sala)
        {
            float respuesta;

            respuesta =
                sala.DecimoTercerSueldo * peso1 +
                sala.DecimoCuartoSueldo * peso2 +
                sala.Utilidades * peso3;

            respuesta = (float) Math.Round((double) respuesta, 2);

            return respuesta;
        }

        public bool SalAprobado(Salario calificacion)
        {
            return salario(calificacion) >= salariominimo;
        }
    }
}
