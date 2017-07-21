﻿using Agenda.Exemplo.Aplicacao.Mapper;
using Agenda.Exemplo.Dominio.Aplicacao;
using Agenda.Exemplo.Dominio.DTO;
using Agenda.Exemplo.Dominio.Repositorio;
using System;
using System.Collections.Generic;

namespace Agenda.Exemplo.Aplicacao
{
    public class GrupoAplicacao : IGrupoAplicacao
    {
        private readonly IGrupoRepositorio _grupoRepositorio;
        
        public GrupoAplicacao(IGrupoRepositorio grupoRepositorio)
        {
            _grupoRepositorio = grupoRepositorio;
        }
        
        public GrupoDTO ObterGrupo(int id)
        {
            return _grupoRepositorio.ObterGrupo(id).CriarDTO();
        }

        public IList<GrupoDTO> ObterGrupos(string nome)
        {
            return _grupoRepositorio.ObterGrupos(nome).CriarDTO();
        }
    }
}