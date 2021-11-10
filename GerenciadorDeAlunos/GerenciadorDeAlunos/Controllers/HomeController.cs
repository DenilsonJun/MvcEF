using System.Web.Mvc;

namespace GerenciadorDeConteudo.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {

            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}