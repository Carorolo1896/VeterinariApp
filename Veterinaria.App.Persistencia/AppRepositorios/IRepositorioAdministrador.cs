using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioAdministrador{

        //Metodo 1
        public Administrador AgregarAdministrador(Administrador administrador);
        //Metodo 2
        public Administrador EditarAdministrador(Administrador administrador);
        //Metodo 3
        public void EliminarAdministrador(int idAdministrador);
        //Metodo 4
        public Administrador GetAdministrador(int idAdministrador);
        //Listado de Admins
        public IEnumerable<Administrador> GetAdministradores();
    }
}