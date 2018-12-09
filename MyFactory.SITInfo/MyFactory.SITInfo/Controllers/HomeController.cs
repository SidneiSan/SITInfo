using MyFactory.SITInfo.DbContexto;
using MyFactory.SITInfo.Models;
using MyFactory.SITInfo.Models.Permissoes;
using MyFactory.SITInfo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFactory.SITInfo.Controllers
{
    [AutorizacaoFilter]
    public class HomeController : Controller
    {

        private SITDbContext db = new SITDbContext();

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        
        /// <param name="returnURL"></param>
        /// <returns></returns>
        public ActionResult Login(string returnURL)
        {
            /*Recebe a url que o usuário tentou acessar*/
            Session["usuariologado"] ="";
            ViewBag.ReturnUrl = returnURL;
            return View();
        }

        /// <param name="login"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ValidaUser([Bind(Include = "Email, Senha, Ativo")] UsuarioViewModel model, string returnUrl)
        {
            if (!ModelState.IsValidField(model.Email) && !ModelState.IsValidField(model.Senha))
            {
                return View(model);
            }

            Usuario usuario = db.Usuarios.FirstOrDefault(u => u.Email == model.Email && u.Senha == model.Senha);
            if (usuario == null)
            {
                ModelState.AddModelError("erro_login", "Usuário não foi localizado! ou Senha incorreta!");
                return View("Login",model);

            }
            else if (!usuario.Ativo)
            {
                ModelState.AddModelError("erro_login", "Usuário não esta Ativo no Sistema!");
                return View("Login", model);
            }

          
            Session["usuariologado"] = usuario.Email;
           

            return  RedirectToAction("Index","Home");

        }

        public ActionResult Negado()
        {
            return View();
        }

        public ActionResult Graficos()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

}