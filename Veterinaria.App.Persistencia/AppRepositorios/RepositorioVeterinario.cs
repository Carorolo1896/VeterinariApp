using System;
using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario{
        private readonly AppContext appContext;

        //constructor
        public RepositorioVeterinario(AppContext appContextParam){
            this.appContext = appContextParam;
        }

        //Metodo 1
        public Veterinario AgregarVeterinario(Veterinario veterinario){
            var veterinarioAgregado = this.appContext.Veterinarios.Add(veterinario);
            this.appContext.SaveChanges();
            return veterinarioAgregado.Entity;
        }

        //Metodo 2
        public Veterinario EditarVeterinario(Veterinario veterinarioEditado){
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(p=>p.Id == veterinarioEditado.Id);
            if (veterinarioEncontrado != null){
                veterinarioEncontrado.Nombre = veterinarioEditado.Nombre;
                veterinarioEncontrado.Telefono = veterinarioEditado.Telefono;
                veterinarioEncontrado.Edad = veterinarioEditado.Edad;
                veterinarioEncontrado.Direccion = veterinarioEditado.Direccion;
                veterinarioEncontrado.Correo = veterinarioEditado.Correo;
                veterinarioEncontrado.Contrasena = veterinarioEditado.Contrasena;
                veterinarioEncontrado.FechaRegistro = veterinarioEditado.FechaRegistro;
                veterinarioEncontrado.Especializacion = veterinarioEditado.Especializacion;
                veterinarioEncontrado.TarjetaProfesional = veterinarioEditado.TarjetaProfesional;
                this.appContext.SaveChanges();
            }
            return veterinarioEncontrado;
        }

        //Metodo 3
        public void EliminarVeterinario(int idVeterinario){
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v=>v.Id == idVeterinario);
            if (veterinarioEncontrado != null){
                this.appContext.Veterinarios.Remove(veterinarioEncontrado);
                this.appContext.SaveChanges();
            }
        }

        //Metodo 4
        public Veterinario GetVeterinario(int idVeterinario){
            return this.appContext.Veterinarios.FirstOrDefault(v=>v.Id == idVeterinario);
        }

        //Listado de veterinarios
        public IEnumerable<Veterinario> GetVeterinarios(){
            return null;
        }

    }
}