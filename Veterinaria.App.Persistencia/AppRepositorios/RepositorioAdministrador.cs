using System;
using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioAdministrador : IRepositorioAdministrador{
        private readonly AppContext appContext;

        //constructor
        public RepositorioAdministrador(AppContext appContextParam){
            this.appContext = appContextParam;
        }

        //Metodo 1
        public Administrador AgregarAdministrador(Administrador administrador){
            var AdministradorAgregado = this.appContext.Administradores.Add(administrador);
            this.appContext.SaveChanges();
            return AdministradorAgregado.Entity;
        }

        //Metodo 2
        public Administrador EditarAdministrador(Administrador AdministradorEditado){
            var AdministradorEncontrado = this.appContext.Administradores.FirstOrDefault(p=>p.Id == AdministradorEditado.Id);
            if ( AdministradorEncontrado!= null){
                AdministradorEncontrado.Nombre = AdministradorEditado.Nombre;
                AdministradorEncontrado.Telefono = AdministradorEditado.Telefono;
                AdministradorEncontrado.Edad = AdministradorEditado.Edad;
                AdministradorEncontrado.Direccion = AdministradorEditado.Direccion;
                AdministradorEncontrado.Correo = AdministradorEditado.Correo;
                AdministradorEncontrado.Contrasena = AdministradorEditado.Contrasena;
                AdministradorEncontrado.FechaRegistro = AdministradorEditado.FechaRegistro;
                AdministradorEncontrado.Permisos = AdministradorEditado.Permisos;
                AdministradorEncontrado.Cargo = AdministradorEditado.Cargo;
                AdministradorEncontrado.Salario = AdministradorEditado.Salario;
                AdministradorEncontrado.Estado = AdministradorEditado.Estado;
                this.appContext.SaveChanges();
            }
            return AdministradorEncontrado;
        }

        //Metodo 3
        public void EliminarAdministrador(int idAdministrador){
            var AdministradorEncontrado = this.appContext.Administradores.FirstOrDefault(v=>v.Id == idAdministrador);
            if (AdministradorEncontrado != null){
                this.appContext.Administradores.Remove(AdministradorEncontrado);
                this.appContext.SaveChanges();
            }
        }

        //Metodo 4
        public Administrador GetAdministrador(int idAdministrador){
            return this.appContext.Administradores.FirstOrDefault(v=>v.Id == idAdministrador);
        }

        //Listado de veterinarios
        public IEnumerable<Administrador> GetAdministradores(){
            return null;
        }

    }
}