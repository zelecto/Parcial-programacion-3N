using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServidiosFormulario : IFormulario
    {
        ArchivosFormulario archivosFormulario;
        List<Formulario> formularios = new List<Formulario>();
        public ServidiosFormulario()
        {
            archivosFormulario = new ArchivosFormulario();
            GetAll();
        }

        public bool Add(Formulario formulario)
        {
            try
            {
                if (formulario != null)
                {
                    return archivosFormulario.Save(formulario);
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int GenerarId()
        {
            GetAll();
            return formularios.Count + 1;
        }

        public double CobroAllEmplazamiento()
        {
            return CalcularCobroAll(GetListaEmplazamiento());
        }
        

        public double CobroAllSinEmplazamiento()
        {
            return CalcularCobroAll(GetListaSinEmplazamiento());
        }

        public double CalcularCobroAll(List<Formulario> formularios)
        {
            double cobro=0;
            foreach (var item in formularios)
            {
                cobro += item.Cobro;
            }
            return cobro;
        }

        public List<Formulario> GetAll()
        {
            if (archivosFormulario.Consultar() == null)
            {
                return formularios = new List<Formulario>();
            }
            return formularios = archivosFormulario.Consultar();
        }

        public List<Formulario> GetListaEmplazamiento()
        {
            return Filtrar(true);
        }

        public List<Formulario> GetListaSinEmplazamiento()
        {
            return Filtrar(false);
        }

        public List<Formulario> Filtrar(bool emplazamiento)
        {
            var listaFiltradaFormularios = new List<Formulario>();
            foreach (var item in archivosFormulario.Consultar())
            {
                if (emplazamiento == item.Sancion)
                {
                    listaFiltradaFormularios.Add(item);
                }
            }
            return listaFiltradaFormularios;
        }
    }
}
