using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BDSql;

namespace Conecta2.Controllers
{
    public class TipoDenunciaController : ApiController
    {
        private conectaDBEntities db = new conectaDBEntities();

        // GET: api/TipoDenuncia
        public IQueryable<BDSqltipo_denuncia> Gettipo_denuncia()
        {
            return (db.tipo_denuncia);
        }

        // GET: api/TipoDenuncia/5
        [ResponseType(typeof(tipo_denuncia))]
        public async Task<IHttpActionResult> Gettipo_denuncia(int id)
        {
            tipo_denuncia tipo_denuncia = await db.tipo_denuncia.FindAsync(id);
            if (tipo_denuncia == null)
            {
                return NotFound();
            }

            return Ok(tipo_denuncia);
        }

        // PUT: api/TipoDenuncia/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Puttipo_denuncia(int id, tipo_denuncia tipo_denuncia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipo_denuncia.id_tipo_denuncia)
            {
                return BadRequest();
            }

            db.Entry(tipo_denuncia).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tipo_denunciaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TipoDenuncia
        [ResponseType(typeof(tipo_denuncia))]
        public async Task<IHttpActionResult> Posttipo_denuncia(tipo_denuncia tipo_denuncia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tipo_denuncia.Add(tipo_denuncia);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tipo_denuncia.id_tipo_denuncia }, tipo_denuncia);
        }

        // DELETE: api/TipoDenuncia/5
        [ResponseType(typeof(tipo_denuncia))]
        public async Task<IHttpActionResult> Deletetipo_denuncia(int id)
        {
            tipo_denuncia tipo_denuncia = await db.tipo_denuncia.FindAsync(id);
            if (tipo_denuncia == null)
            {
                return NotFound();
            }

            db.tipo_denuncia.Remove(tipo_denuncia);
            await db.SaveChangesAsync();

            return Ok(tipo_denuncia);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tipo_denunciaExists(int id)
        {
            return db.tipo_denuncia.Count(e => e.id_tipo_denuncia == id) > 0;
        }
    }
}