using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioDueñoMascota{

        //Metodo 1
        public DueñoMascota AgregarDueñoMascota(DueñoMascota dueño);
        //Metodo 2
        public DueñoMascota EditarDueñoMascota(DueñoMascota dueño);
        //Metodo 3
        public void EliminarDueñoMascota(int idDueñoMascota);
        //Metodo 4
        public DueñoMascota GetDueñoMascota(int idDueñoMascota);
        //Listado de veterinarios
        public IEnumerable<DueñoMascota> GetDueñoMascota();
    }
}