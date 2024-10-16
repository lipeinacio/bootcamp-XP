using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioMinimalAPI.Dominio.Interfaces;
using Dominio.DTOs;
using Dominio.Entidades;
using Infraestrutura.Db;

namespace DesafioMinimalAPI.Dominio.Sevicos
{
    public class AdministradorServico : IAdministradorServico
    {
        private readonly DbContexto _contexto;
        public AdministradorServico(DbContexto db)
        {
            _contexto = db;
        }

        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
            return adm;

        }
    }
}