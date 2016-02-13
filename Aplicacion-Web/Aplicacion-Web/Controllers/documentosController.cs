using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aplicacion_Web;

namespace Aplicacion_Web.Controllers
{
    public class documentosController : Controller
    {
        private ModelCNX db = new ModelCNX();

        // GET: documentos
        public ActionResult Index()
        {
            var documentos = db.documentos.Include(d => d.tipo_documento);
            return View(documentos.ToList());
        }

        // GET: documentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            documentos documentos = db.documentos.Find(id);
            if (documentos == null)
            {
                return HttpNotFound();
            }
            return View(documentos);
        }

        // GET: documentos/Create
        public ActionResult Create()
        {
            ViewBag.id_tipo_doc = new SelectList(db.tipo_documento, "id_tipo_doc", "Tipo_doc");
            return View();
        }

        // POST: documentos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_doc,id_tipo_doc,Cedula,Nom_doc_encon,Ape_doc_encon,Ced_per_encon,Nom_pers_encon,Ape_perso_encon,Nmr_contacto,Email_contacto,Lugar_encon,Fecha_registro")] documentos documentos)
        {
            if (ModelState.IsValid)
            {
                db.documentos.Add(documentos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_tipo_doc = new SelectList(db.tipo_documento, "id_tipo_doc", "Tipo_doc", documentos.id_tipo_doc);
            return View(documentos);
        }

        // GET: documentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            documentos documentos = db.documentos.Find(id);
            if (documentos == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_tipo_doc = new SelectList(db.tipo_documento, "id_tipo_doc", "Tipo_doc", documentos.id_tipo_doc);
            return View(documentos);
        }

        // POST: documentos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_doc,id_tipo_doc,Cedula,Nom_doc_encon,Ape_doc_encon,Ced_per_encon,Nom_pers_encon,Ape_perso_encon,Nmr_contacto,Email_contacto,Lugar_encon,Fecha_registro")] documentos documentos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(documentos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_tipo_doc = new SelectList(db.tipo_documento, "id_tipo_doc", "Tipo_doc", documentos.id_tipo_doc);
            return View(documentos);
        }

        // GET: documentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            documentos documentos = db.documentos.Find(id);
            if (documentos == null)
            {
                return HttpNotFound();
            }
            return View(documentos);
        }

        // POST: documentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            documentos documentos = db.documentos.Find(id);
            db.documentos.Remove(documentos);
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
