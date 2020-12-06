namespace demo_crud.Migrations
{
    using demo_crud.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<demo_crud.Models.UsuarioContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "demo_crud.Models.UsuarioContext";
        }

        protected override void Seed(demo_crud.Models.UsuarioContext context)
        {


            // usuarios

            Usuario u1 = new Usuario()
            {
                Id = 1,
                Nombre = "claudio",
                Apellido = "quezada",
                Edad = 35,
                Direccion = "chiguayante 1",
                Telefono = 123456789


            };
            Usuario u2 = new Usuario()
            {
                Id = 2,
                Nombre = "andres",
                Apellido = "garcia",
                Edad = 30,
                Direccion = "concepcion 2",
                Telefono = 987654321


            };
            Usuario u3 = new Usuario()
            {
                Id = 3,
                Nombre = "andrea",
                Apellido = "toro",
                Edad = 33,
                Direccion = "hualqui 305",
                Telefono = 123789456


            };

            context.Usuarios.Add(u1);

            context.Usuarios.Add(u2);

            context.Usuarios.Add(u3);

            context.SaveChanges();



        }
    }
}
