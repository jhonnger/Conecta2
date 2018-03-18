using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BDSql;

namespace Conecta2.Controllers
{
    public class TipoDenunciaController : Controller
    {
        private conectaDBEntities db = new conectaDBEntities();

        // GET: TipoDenuncia
        public async Task<JsonResult> Index()
        {
            return Json(await db.tipo_denuncia.ToListAsync());
        }

        // GET: TipoDenuncia/Details/5
        public async Task<JsonResult> Details(int? id)
        {
            return Json(await db.tipo_denuncia.ToListAsync());
            /**if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipo_denuncia tipo_denuncia = await db.tipo_denuncia.FindAsync(id);
            if (tipo_denuncia == null)
            {
                return HttpNotFound();
            }
            return View(tipo_denuncia); **/
        }

        // GET: TipoDenuncia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDenuncia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id_tipo_denuncia,nombre,descripcion,usuario_mod,fec_creacion,fecha_modificacion,estado")] tipo_denuncia tipo_denuncia)
        {
            if (ModelState.IsValid)
            {
                db.tipo_denuncia.Add(tipo_denuncia);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tipo_denuncia);
        }

        // GET: TipoDenuncia/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipo_denuncia tipo_denuncia = await db.tipo_denuncia.FindAsync(id);
            if (tipo_denuncia == null)
            {
                return HttpNotFound();
            }
            return View(tipo_denuncia);
        }

        // POST: TipoDenuncia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id_tipo_denuncia,nombre,descripcion,usuario_mod,fec_creacion,fecha_modificacion,estado")] tipo_denuncia tipo_denuncia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipo_denuncia).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tipo_denuncia);
        }

        // GET: TipoDenuncia/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipo_denuncia tipo_denuncia = await db.tipo_denuncia.FindAsync(id);
            if (tipo_denuncia == null)
            {
                return HttpNotFound();
            }
            return View(tipo_denuncia);
        }

        // POST: TipoDenuncia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tipo_denuncia tipo_denuncia = await db.tipo_denuncia.FindAsync(id);
            db.tipo_denuncia.Remove(tipo_denuncia);
            await db.SaveChangesAsync();
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
