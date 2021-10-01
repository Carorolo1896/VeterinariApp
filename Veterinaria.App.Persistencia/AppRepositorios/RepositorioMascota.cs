using System;
using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota{
        private readonly AppContext appContext;

        public RepositorioMascota (AppContext appContextParam){
            this.appContext = appContextParam;
        }

        public Mascota AgregarMascota (Mascota mascota){
            var MascotaAgragada = this.appContext.Mascotas.Add(mascota);
                this.appContext.SaveChanges();
                return MascotaAgragada.Entity;
            }

        public Mascota EditarMascota (Mascota MascotaEditada){
            var MascotaEncontrada = this.appContext.Mascotas.FirstOrDefault (p =>p.ID == MascotaEditada.ID);
            if (MascotaEncontrada != null){
                MascotaEncontrada.Fecha_Nacimiento = MascotaEditada.Fecha_Nacimiento;
                MascotaEncontrada.Nombre_M = MascotaEditada.Nombre_M;
                MascotaEncontrada.ID = MascotaEditada.ID;
                MascotaEncontrada.Pedigree = MascotaEditada.Pedigree;
                MascotaEncontrada.Edad = MascotaEditada.Edad;
                MascotaEncontrada.Color = MascotaEditada.Color;
                MascotaEncontrada.Raza = MascotaEncontrada.Raza;
                this.appContext.SaveChanges();
            }
            return MascotaEncontrada;
            }
        public void EliminarMascota (int IdMascota){
            var MascotaEncontrada = this.appContext.Mascotas.FirstOrDefault(l=>l.ID == IdMascota);
            if (MascotaEncontrada != null){
                this.appContext.Mascotas.Remove(MascotaEncontrada);
                this.appContext.SaveChanges();
            }
        }
        public Mascota GetMascota (int IdMascota){
            return this.appContext.Mascotas.FirstOrDefault (s => s.ID == IdMascota);
        }
        public IEnumerable<Mascota> GetMascotas(){
            return null;
        }
    }
}