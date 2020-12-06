using demo_crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo_crud.Controllers
{
    public class UsuariosController : Controller
    {

        private UsuarioContext _db;



        private List<Usuario> GetUsuarios()
        {

            //creamos los usuarios

            Usuario alexis = new Usuario()
            {
                Id = 1,
                Nombre = "alexis",
                Apellido = "sanchez",
                Edad = 30,
                Direccion = "santiago",
                Telefono = 123456

            };
            Usuario carlos = new Usuario()
            {
                Id = 2,
                Nombre = "carlos",
                Apellido = "sanchez",
                Edad = 30,
                Direccion = "santiago",
                Telefono = 123456

            };
            Usuario juan = new Usuario()
            {
                Id = 3,
                Nombre = "juan",
                Apellido = "sanchez",
                Edad = 30,
                Direccion = "santiago",
                Telefono = 123456

            };

            List<Usuario> lista = new List<Usuario>();

            lista.Add(alexis);
            lista.Add(carlos);
            lista.Add(juan);

            return lista;


        }
        // GET: Usuarios

        [HttpGet]
        public ActionResult Index()
        {
            // List<Usuario> misUsuarios = GetUsuarios();


            //return View(misUsuarios);

            IEnumerable<Usuario> usuarios = null;
            using (_db = new UsuarioContext())
            {
                usuarios = _db.Usuarios.ToList();  // equivale a un select from users// Use Local DB de sql server code firrst

            }
            return View(usuarios);


        }

        [HttpGet]
        public ActionResult Nuevo()  //el nuevo con get me despliega el formulario
        {

            Usuario usuario = new Usuario();
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(Usuario usuario) // este action procesara los datos , con el metodo post
        {
            if (ModelState.IsValid)
            {//aca se guardaria en bd
             //   return RedirectToAction("Index", "Usuarios");

                _db = new UsuarioContext();
                _db.Usuarios.Add(usuario);
                _db.SaveChanges();
                return RedirectToAction("Index", "Usuarios");
            }
           // else
            //{

                return View(usuario);
            //}

           
        }


        [HttpGet]
        public ActionResult Ver(int id)
        {
            //ViewBag.id = id;

            Usuario u = null;
            using (_db = new UsuarioContext())
            {

                u = _db.Usuarios.Find(id);
            }

                return View(u);
        }


        [HttpGet]
        public ActionResult Editar(int id)
        {
            // ViewBag.id = id;

            //return View();


            Usuario u = null;
            using (_db = new UsuarioContext())
            {

                u = _db.Usuarios.Find(id);
            }

            return View(u);

        }

        //************************************************

        [HttpPost]
        public ActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {

                _db = new UsuarioContext();
                _db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", "Usuarios", new { id= usuario.Id});
            }
            // else
            //{

            return View(usuario);

        }



        [HttpPost]  // se usa post por que se usa para el envio de los datos
        public ActionResult Crear()   // procesa lo de Nuevo
        {
            return View();
        }

        [HttpPost]   // se usa post por que se usa para el envio de los datos
        public ActionResult Actualizar()   // procesa los datos de editar
        {
            return View();
        }

    }
}