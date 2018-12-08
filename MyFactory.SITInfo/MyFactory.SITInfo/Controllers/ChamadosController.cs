using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyFactory.SITInfo.DbContexto;
using MyFactory.SITInfo.Models;
using MyFactory.SITInfo.Models.Permissoes;

namespace MyFactory.SITInfo.Controllers
{
    [AutorizacaoFilter]
    public class ChamadosController : Controller
    {
        private SITDbContext db = new SITDbContext();
       
        // GET: Chamados
        public ActionResult Index()
        {
            return View(db.Chamados.ToList());
        }

        // GET: Chamados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamado chamado = db.Chamados.Find(id);
            if (chamado == null)
            {
                return HttpNotFound();
            }
            return View(chamado);
        }

        // GET: Chamados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chamados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,EmailUsuario,DataAbertura,Prioridade,Titulo,Descricao,DataFechamento")] Chamado chamado)
        {
            if (ModelState.IsValid)
            {
                db.Chamados.Add(chamado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chamado);
        }

        // GET: Chamados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamado chamado = db.Chamados.Find(id);
            if (chamado == null)
            {
                return HttpNotFound();
            }
            return View(chamado);
        }

        // POST: Chamados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,EmailUsuario,DataAbertura,Prioridade,Titulo,Descricao,DataFechamento")] Chamado chamado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chamado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chamado);
        }

        // GET: Chamados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamado chamado = db.Chamados.Find(id);
            if (chamado == null)
            {
                return HttpNotFound();
            }
            return View(chamado);
        }

        // POST: Chamados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Chamado chamado = db.Chamados.Find(id);
            db.Chamados.Remove(chamado);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
