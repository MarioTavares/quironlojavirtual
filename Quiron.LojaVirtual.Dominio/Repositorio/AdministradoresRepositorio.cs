﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidade;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class AdministradoresRepositorio
    {

        private readonly EfDbContext _context = new EfDbContext();

        public Administrador ObterAdministrador(Administrador administrador)
        {

            return _context.Administradores.FirstOrDefault(a=> a.Login == administrador.Login);

        }



    }
}
