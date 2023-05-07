using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Formulario
    {
        public Formulario()
        {         
        }

        public int Id { get; set; }
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public bool Sancion { get; set; }
        public double SalarioMinimoActual { get; set; }
        public double ValorDeclarado { get; set; }
        public double Cobro { get; set; }
        

        public double CalcularCobro()
        {
            int diaExponalidad=Fecha.Day-DateTime.Now.Day;
            if (diaExponalidad < 0)
            {
                diaExponalidad = -1 * diaExponalidad;
            }
            if (Sancion)
            {
                return ValorDeclarado * diaExponalidad * 0.3;
            }
            return ValorDeclarado * diaExponalidad * (SalarioMinimoActual*4);
        }
        public double CalcularSalarioMinimo()
        {
            return 1160000 / DateTime.DaysInMonth(Fecha.Year, Fecha.Month); 
        }

        public override string ToString()
        {
            return $"{Id};{Cedula};{Nombre};{Fecha};{Sancion};{ValorDeclarado};{Cobro};{SalarioMinimoActual}";
        }
    }
}
