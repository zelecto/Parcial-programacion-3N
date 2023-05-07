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
            throw new NotImplementedException();
        }

        public double CobroAllSinEmplazamiento()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Formulario> GetListaSinEmplazamiento()
        {
            throw new NotImplementedException();
        }

        public Formulario Search()
        {
            throw new NotImplementedException();
        }
    }
}
