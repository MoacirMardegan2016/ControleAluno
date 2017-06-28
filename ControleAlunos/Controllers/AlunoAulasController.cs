using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControleAlunos.Context;
using ControleAlunos.Models;

namespace ControleAlunos.Controllers
{
    public class AlunoAulasController : Controller
    {
        private ControleAlunosContext db = new ControleAlunosContext();

        // GET: AlunoAulas
        public ActionResult Index()
        {
            var alunoAula = db.AlunoAula.Include(a => a.Aluno).Include(a => a.Aula);
            return View(alunoAula.ToList());
        }

        // GET: AlunoAulas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlunoAula alunoAula = db.AlunoAula.Find(id);
            if (alunoAula == null)
            {
                return HttpNotFound();
            }
            return View(alunoAula);
        }

        // GET: AlunoAulas/Create
        public ActionResult Create()
        {
            ViewBag.IdAluno = new SelectList(db.Aluno, "IdAluno", "NomeAluno");
            ViewBag.IdAula = new SelectList(db.Aula, "IdAula", "DescricaoAula");
            return View();
        }

        // POST: AlunoAulas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAluno,IdAula")] AlunoAula alunoAula)
        {
            if (ModelState.IsValid)
            {
                db.AlunoAula.Add(alunoAula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdAluno = new SelectList(db.Aluno, "IdAluno", "NomeAluno", alunoAula.IdAluno);
            ViewBag.IdAula = new SelectList(db.Aula, "IdAula", "DescricaoAula", alunoAula.IdAula);
            return View(alunoAula);
        }

        // GET: AlunoAulas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlunoAula alunoAula = db.AlunoAula.Find(id);
            if (alunoAula == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAluno = new SelectList(db.Aluno, "IdAluno", "NomeAluno", alunoAula.IdAluno);
            ViewBag.IdAula = new SelectList(db.Aula, "IdAula", "DescricaoAula", alunoAula.IdAula);
            return View(alunoAula);
        }

        // POST: AlunoAulas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAluno,IdAula")] AlunoAula alunoAula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alunoAula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdAluno = new SelectList(db.Aluno, "IdAluno", "NomeAluno", alunoAula.IdAluno);
            ViewBag.IdAula = new SelectList(db.Aula, "IdAula", "DescricaoAula", alunoAula.IdAula);
            return View(alunoAula);
        }

        // GET: AlunoAulas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlunoAula alunoAula = db.AlunoAula.Find(id);
            if (alunoAula == null)
            {
                return HttpNotFound();
            }
            return View(alunoAula);
        }

        // POST: AlunoAulas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AlunoAula alunoAula = db.AlunoAula.Find(id);
            db.AlunoAula.Remove(alunoAula);
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

        public ActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlunoAula alunoAula = db.AlunoAula.Find(id);
            if (alunoAula == null)
            {
                return HttpNotFound();
            }
            return View(alunoAula);
        }
    }
}
