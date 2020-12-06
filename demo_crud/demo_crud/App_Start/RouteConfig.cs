using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace demo_crud
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Usuarios", action = "Index", id= UrlParameter.Optional }


    );





            /*   routes.MapRoute(
                   name: "raiz",
                   url: "",
                   defaults: new { controller = "Usuarios", action = "Index" },
                   constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }


                   );


               // Rutas del usuario


               routes.MapRoute(
                  name: "usuarios",
                  url: "usuarios",
                  defaults: new { controller = "Usuarios", action = "Index" },
                  constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }


                  );

               routes.MapRoute(
               name: "nuevo_usuario",
               url: "usuarios/nuevo",
               defaults: new { controller = "Usuarios", action = "Nuevo" },
               constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }


               );


             routes.MapRoute(
             name: "ver_usuario",
             url: "usuarios/{id}",
             defaults: new { controller = "Usuarios", action = "Ver" },
             constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }


             );

               routes.MapRoute(
            name: "editar_usuario",
            url: "usuarios/{id}/editar",
            defaults: new { controller = "Usuarios", action = "Editar" },
            constraints: new { httpMethod = new HttpMethodConstraint(new string[] { "GET" }) }


            );*/
        }
    }
}
