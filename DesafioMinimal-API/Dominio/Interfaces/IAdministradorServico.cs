using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.DTOs;
using Dominio.Entidades;

namespace DesafioMinimalAPI.Dominio.Interfaces;

    public interface IAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO);
        Administrador? Incluir(Administrador administrador);
        List<Administrador> Todos(int? pagina);
        Administrador? BuscaPorId(int id);
    }
