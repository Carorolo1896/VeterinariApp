using System;
using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioDueñoMascota : IRepositorioDueñoMascota{
        private readonly AppContext appContext;

        //constructor
        public RepositorioDueñoMascota(AppContext appContextParam){
            this.appContext = appContextParam;
        }

        //Metodo 1
        public DueñoMascota AgregarDueñoMascota(DueñoMascota dueñoMascota){
            var DueñoMascotaAgregado = this.appContext.Dueños.Add(dueñoMascota);
            this.appContext.SaveChanges();
            return DueñoMascotaAgregado.Entity;
        }

        //Metodo 2
        public DueñoMascota EditarDueñoMascota(DueñoMascota DueñoMascotaEditado){
            var DueñoMascotaEncontrado = this.appContext.Dueños.FirstOrDefault(p=>p.Id == DueñoMascotaEditado.Id);
            if ( DueñoMascotaEncontrado!= null){
                DueñoMascotaEncontrado.Nombre = DueñoMascotaEditado.Nombre;
                DueñoMascotaEncontrado.Telefono = DueñoMascotaEditado.Telefono;
                DueñoMascotaEncontrado.Edad = DueñoMascotaEditado.Edad;
                DueñoMascotaEncontrado.Direccion = DueñoMascotaEditado.Direccion;
                DueñoMascotaEncontrado.Correo = DueñoMascotaEditado.Correo;
                DueñoMascotaEncontrado.Contrasena = DueñoMascotaEditado.Contrasena;
                DueñoMascotaEncontrado.FechaRegistro = DueñoMascotaEditado.FechaRegistro;
                DueñoMascotaEncontrado.Mascota_ = DueñoMascotaEditado.Mascota_;
                DueñoMascotaEncontrado.Profesion = DueñoMascotaEditado.Profesion;
                this.appContext.SaveChanges();
            }                                                                
            return DueñoMascotaEncontrado;
        }

        //Metodo 3
        public void EliminarDueñoMascota(int idDueñoMascota){
            var DueñoMascotaEncontrado = this.appContext.Dueños.FirstOrDefault(v=>v.Id == idDueñoMascota);
            if (DueñoMascotaEncontrado != null){
                this.appContext.Dueños.Remove(DueñoMascotaEncontrado);
                this.appContext.SaveChanges();
            }
        }

        //Metodo 4
        public DueñoMascota GetDueñoMascota(int idDueñoMascota){
            return this.appContext.Dueños.FirstOrDefault(v=>v.Id == idDueñoMascota);
        }

        //Listado de veterinarios
        public IEnumerable<DueñoMascota> GetDueñoMascota(){
            return null;
        }

    }
}