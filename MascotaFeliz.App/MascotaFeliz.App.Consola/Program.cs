using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;


namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.Appcontext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Amigos vamos a empezar a trabajar con las tablas");
            //AddDueno();
        }
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "333333",
                Nombres = "Juan",
                Apellidos = "salazar",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
    }
}
