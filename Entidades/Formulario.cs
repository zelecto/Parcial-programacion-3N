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

        public Formulario(int id, long cedula, string nombre, DateTime fecha, bool sancion, double valorDeclarado, double cobro)
        {
            Id = id;
            Cedula = cedula;
            Nombre = nombre;
            Fecha = fecha;
            Sancion = sancion;
            ValorDeclarado = valorDeclarado;
            Cobro = cobro;
        }

        public int Id { get; set; }
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public bool Sancion { get; set; }
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
            return ValorDeclarado * Fecha.Day * 1160000;
        }

        public override string ToString()
        {
            return $"{Id};{Cedula};{Nombre};{Fecha};{Sancion};{ValorDeclarado};{Cobro}";
        }
    }
}
