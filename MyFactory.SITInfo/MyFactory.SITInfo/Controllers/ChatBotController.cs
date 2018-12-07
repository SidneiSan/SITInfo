using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatsonLib;

namespace MyFactory.SITInfo.Controllers
{
    public class ChatBotController : Controller
    {
        private AssistantServiceExample watson;
        public ChatBotController()
        {
             watson = new AssistantServiceExample("https://gateway.watsonplatform.net/assistant/api", "apikey", "u38Mpwg9ObVHv78IrJvNtBIO9n85VJBUydh3ta6QwRCL", "d7e27d20-2763-4647-9bc2-5eb1b613eb36");
        }
        // GET: ChatBot
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult FalaWatson(string pergunta)
        {
            var resposta = watson.CallAssistant(pergunta);

            if (resposta != null)
            {
                return Json(resposta);
            }

            return null;
        }
    }



}