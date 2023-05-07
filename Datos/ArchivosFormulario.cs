using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ArchivosFormulario
    {
        string ruta = "Formulario.txt";

        public bool Save(Formulario formulario)
        {
            var sw = new StreamWriter(ruta, true);
            try
            {
                sw.WriteLine(formulario.ToString());
                sw.Close();
                return true;
            }
            catch (Exception)
            {
                sw.Close();
                return false;
            }

        }


        public List<Formulario> Consultar()
        {
            if (File.Exists(ruta))
            {
                List<Formulario> Formulario = new List<Formulario>();

                try
                {
                    var sr = new StreamReader(ruta);
                    while (!sr.EndOfStream)
                    {
                        Formulario.Add(Mapeador(sr.ReadLine()));
                    }
                    sr.Close();
                    return Formulario;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }


        public Formulario Mapeador(string linea)
        {
            Formulario formulario = new Formulario();
            try
            {
                var auxi = linea.Split(';');

                formulario.Id = int.Parse(auxi[0]);
                formulario.Cedula = long.Parse(auxi[1]);
                formulario.Nombre = auxi[2];
                formulario.Fecha = DateTime.Parse(auxi[3]);
                formulario.Sancion = bool.Parse(auxi[4]);
                formulario.ValorDeclarado = double.Parse(auxi[5]);
                formulario.Cobro = double.Parse(auxi[6]);
                return formulario;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
