using System.Web.Mvc;
using System.Web.Routing;

namespace GerenciadorDeConteudo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Contato",
               url: "Contato",
               defaults: new { controller = "Home", action = "Contato" }
            );

            routes.MapRoute(
              name: "Cobre",
              url: "Sobre",
              defaults: new { controller = "Home", action = "Sobre" }
           );

            routes.MapRoute(
               name: "Alunos",
               url: "Alunos",
               defaults: new { controller = "Alunos", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
