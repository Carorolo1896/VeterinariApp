using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioVeterinario{

        //Metodo 1
        public Veterinario AgregarVeterinario(Veterinario veterinario);
        //Metodo 2
        public Veterinario EditarVeterinario(Veterinario veterinario);
        //Metodo 3
        public void EliminarVeterinario(int idVeterinario);
        //Metodo 4
        public Veterinario GetVeterinario(int idVeterinario);
        //Listado de veterinarios
        public IEnumerable<Veterinario> GetVeterinarios();
    }
}