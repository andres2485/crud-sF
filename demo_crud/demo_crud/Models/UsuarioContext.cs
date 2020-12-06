using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace demo_crud.Models
{
    public class UsuarioContext : DbContext
    {


        public DbSet<Usuario> Usuarios { get; set; }
    }
}