﻿using Agenda.Exemplo.Dominio.Entidade;
using System.Collections.Generic;

namespace Agenda.Exemplo.Dominio.Repositorio
{
    public interface IGrupoRepositorio
    {
        Grupo ObterGrupo(int id);
        IList<Grupo> ObterGrupos(string nome);
        int InserirGrupo(Grupo grupo);
        void EditarGrupo(Grupo grupo);
        void RemoverGrupo(int id);
    }
}
