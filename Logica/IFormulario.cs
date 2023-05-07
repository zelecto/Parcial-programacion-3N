﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IFormulario
    {
        bool Add(Formulario formulario);
        Formulario Search();
        List<Formulario> GetAll();
        List<Formulario> GetListaEmplazamiento();
        List<Formulario> GetListaSinEmplazamiento();
        double CobroAllEmplazamiento();
        double CobroAllSinEmplazamiento();

    }
}
