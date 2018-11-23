using MyFactory.SITInfo.DbContexto;
using MyFactory.SITInfo.Models;
using MyFactory.SITInfo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFactory.SITInfo.Controllers
{
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
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidaUser([Bind(Include = "Email, Senha")] UsuarioViewModel model)
        {
            if (!ModelState.IsValidField(model.Email) && !ModelState.IsValidField(model.Senha))
            {
                return View(model);
            }


            Usuario usuario = db.Usuarios.FirstOrDefault(u => u.Email == model.Email && u.Senha == model.Senha);
            if (usuario == null)
            {
                ModelState.AddModelError("erro_login", "Usuário não foi localizado!");
                return View("Login",model);
            }


            Console.WriteLine("vazio");



            return View();

        }




        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

}