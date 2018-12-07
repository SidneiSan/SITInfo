using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MyFactory.SITInfo.Models.Permissoes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AutorizacaoFilter : ActionFilterAttribute
    {
        //Antes de executar o controller
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object usuarioLogado = filterContext.HttpContext.Session["usuarioLogado"];
            if (usuarioLogado == null || usuarioLogado == "")
            {
                if (filterContext.Controller is MyFactory.SITInfo.Controllers.HomeController)
                {
                    //Nao faz nada
                }
                else
                {
                    //filterContext.Result = new RedirectToRouteResult(
                    //            new RouteValueDictionary(
                    //               new { action = "Erro", controller = "Login" }));
                    filterContext.HttpContext.Response.Redirect("/Home/Negado");
                }
            }
        }
    }
}