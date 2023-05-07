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
            Fecha = DateTime.Now;
            Sancion = ValidarSancion();            
        }

       

        public int Id { get; set; }
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public bool Sancion { get; set; }
        public double SalarioMinimoActual { get; set; }
        public double ValorDeclarado { get; set; }
        public double Cobro { get; set; }
        

        public bool ValidarSancion()
        {
            if (Fecha.Day>10)
            {
                return true;
            }
            return false;
        }

        public double CalcularCobro()
        {
            if (Sancion)
            {
                return ValorDeclarado * Fecha.Day * 0.3;
            }
            return ValorDeclarado * Fecha.Day * (SalarioMinimoActual*4);
        }
        //Esta funcion determina el valor por 4 del salario minimo leagal vigente
        
        public override string ToString()
        {
            return $"{Id};{Cedula};{Nombre};{Fecha};{Sancion};{ValorDeclarado};{Cobro};{SalarioMinimoActual}";
        }
    }
}
