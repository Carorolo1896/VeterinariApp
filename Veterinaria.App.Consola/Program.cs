using System;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Consola
{
    class Program
    {
        private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioAdministrador repositorioAdministrador = new RepositorioAdministrador(new Persistencia.AppContext());
        private static IRepositorioDueñoMascota repositorioDueñoMascota = new RepositorioDueñoMascota(new Persistencia.AppContext());
        private static IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            //Console.WriteLine("Proceso realizado");
            //AgregarVeterinario();
            //EliminarVeterinario(4);
            //GetVeterinario(1);
            //EditarVeterinario(4);

            //AgregarAdministrador();
            //EditarAdministrador(1);
            //EliminarAdministrador();
            //GetAdministrador(2);
            //EditarAdministrador();

            //AgregarDueñoMascota();
            //EditarDueñoMascota(5);
            //EliminarDueñoMascota(6);
            //GetDueñoMascota(5);
            //EditarDueñoMascota();

            //AgregarMascota();
            //GetMascota(1);
            EliminarMascota(1);
        }

        private static void AgregarVeterinario(){
            Console.WriteLine("Veterinario Agregado exitosamente");
            Veterinario veterinario = new Veterinario{
                
                Nombre = "Carlos",
                Telefono = "5897635",
                Edad = 28,
                Direccion = "AV 98 # 70BB - 87",
                Correo = "carlos@gmail.co",
                FechaRegistro = new DateTime(2021,08,27),
                Especializacion = "Anestesiologo",
                TarjetaProfesional = "10002956238",
                Contrasena = "ahudyv72!",
            };
            repositorioVeterinario.AgregarVeterinario(veterinario);
        }

        private static void EditarVeterinario(int idVeterinario){
            Console.WriteLine("Se han actualizado los datos correctamente");
            Veterinario veterinario = new Veterinario{
                Id = idVeterinario,
                Nombre = "Andres",
                Telefono = "4567895",
                Edad = 36,
                Direccion = "Hidraulica",
                Correo = "nidea@prueba.com",
                FechaRegistro = new DateTime(2021,09,21),
                Especializacion = "anestesiologia",
                TarjetaProfesional = "8943754076",
            };
            repositorioVeterinario.EditarVeterinario(veterinario);
        }

        private static void EliminarVeterinario(int idVeterinario){
            Console.WriteLine("Veterinario eliminado correctamente");
            repositorioVeterinario.EliminarVeterinario(idVeterinario);
        }

        private static void GetVeterinario(int idVeterinario){
            var veterinarioObtenido = repositorioVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("El nombre del veterinario es: " + veterinarioObtenido.Nombre);
        }
    

        private static void AgregarAdministrador(){
            Console.WriteLine("Administrador agregado exitosamente");
            Administrador administrador = new Administrador{
                Nombre = "Fernando",
                Telefono = "3109826348",
                Edad = 27,
                Direccion = "CR 74B # 87 - 167 INT 200",
                Correo = "fernando@gmail.com",
                FechaRegistro = new DateTime(2021,09,02), 
                Cargo = "Gerente",
                Salario = "$ 4'200.000",
                Estado = "Activo",
                Permisos = "Si",
                Contrasena = "&sidh34@",
            };
            repositorioAdministrador.AgregarAdministrador(administrador);
        }

        private static void EditarAdministrador(int idAdministrador){
            Console.WriteLine("Se han actualizado los datos correctamente");
            Administrador Administrador = new Administrador{
                Id = idAdministrador,
                Nombre = "camilo",
                Telefono = "4567895",
                Edad = 35,
                Direccion = "no se sabe",
                Correo = "nidea@prueba.com",
                FechaRegistro = new DateTime(2021,09,21),
                Cargo = "anestesiologia",
                Salario = "$ 4.000.000",
                Contrasena = "@briwl54",
                Permisos = "Si",
            };
            repositorioAdministrador.EditarAdministrador(Administrador);
        }
    
        private static void EliminarAdministrador(int idAdministrador){
            Console.WriteLine("Administrador eliminado correctamente");
            repositorioAdministrador.EliminarAdministrador(idAdministrador);
        }
    
        private static void GetAdministrador(int idAdministrador){
            var AdministradorObtenido = repositorioAdministrador.GetAdministrador(idAdministrador);
            Console.WriteLine("El nombre del Administrador es: " + AdministradorObtenido.Nombre);
        }

        private static void AgregarDueñoMascota(){
            Console.WriteLine("Dueño Mascota agregado exitosamente");
            DueñoMascota dueño = new DueñoMascota{
                Nombre = "Felipe",
                Telefono = "3214829649",
                Edad = 29,
                Direccion = "CR 50 # 78A - 203",
                Correo = "pipe@gmail.com",
                FechaRegistro = new DateTime(2019,09,22),
                Mascota_= "Gato",
                Profesion = "Estudiante",
            };
            repositorioDueñoMascota.AgregarDueñoMascota(dueño);
        }

        private static void EditarDueñoMascota(int idDueñoMascota){
            Console.WriteLine("Se han actualizado los datos correctamente");
            DueñoMascota dueño = new DueñoMascota{
                Id = idDueñoMascota,
                Nombre = "Luis Eduardo",
                Telefono = "3214829649",
                Edad = 29,
                Direccion = "CR 50 # 78A - 203",
                Correo = "pipe@gmail.com",
                FechaRegistro = new DateTime(2019,09,22),
                Mascota_= "Gato",
                Profesion = "Estudiante",
                Contrasena = "@#hola"                    
            };
            repositorioDueñoMascota.EditarDueñoMascota(dueño);
        }
    
        private static void EliminarDueñoMascota(int idDueñoMascota){
            Console.WriteLine("Dueño eliminado correctamente");
            repositorioDueñoMascota.EliminarDueñoMascota(idDueñoMascota);
        }
    
        private static void GetDueñoMascota(int idDueñoMascota){
            var DueñoMascotaObtenido = repositorioDueñoMascota.GetDueñoMascota(idDueñoMascota);
            Console.WriteLine("El dueñ@ de la mascota es: " + DueñoMascotaObtenido.Nombre);
        }

        private static void AgregarMascota(){
            Console.WriteLine("Mascota agregada exitosamente");
            Mascota mascota = new Mascota{
                Fecha_Nacimiento = new DateTime(2018, 06, 13),
                Nombre_M = "Alika",
                Pedigree = "NA",
                Edad = "3",
                Color = "Negro",
                Raza = "Labrador",
            };
            repositorioMascota.AgregarMascota(mascota);
        }
        private static void EliminarMascota(int idMascota){
            Console.WriteLine("Mascota eliminada correctamente");
            repositorioMascota.EliminarMascota(idMascota);
        }
    
        private static void GetMascota(int idMascota){
            var MascotaObtenida = repositorioMascota.GetMascota(idMascota);
            Console.WriteLine("La mascota seleccionada es: " + MascotaObtenida.Raza + ", y su nombre es: " + MascotaObtenida.Nombre_M);
            Console.WriteLine("-----------------------------");
        }
    }
}
    
