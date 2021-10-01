using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioMascota{
        //Metodo 1
        public Mascota AgregarMascota(Mascota mascota);
        //Metodo 2
        public Mascota EditarMascota(Mascota mascota);
        //Metodo 3
        public void EliminarMascota(int IDMascota);
        //Metodo 4
        public Mascota GetMascota(int IDMascota);
        //Listado de veterinarios
        public IEnumerable<Mascota> GetMascotas();
    }
    
}