using GerenciadorDeAlunos.DataBase.EF.Context;
using GerenciadorDeAlunos.Models.Entity;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDeConteudo.Controllers
{
    public class AlunosController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: Alunos
        public async Task<ActionResult> Index()
        {
            return View(await db.Alunos.ToListAsync());
        }

        // GET: Alunos/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alunos alunos = await db.Alunos.FindAsync(id);
            if (alunos == null)
            {
                return HttpNotFound();
            }
            return View(alunos);
        }

        // GET: Alunos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Nome,Nascimento,Responsavel,Telefone,Endereco,Sexo,Graduacao,Status")] Alunos alunos)
        {
            if (ModelState.IsValid)
            {
                db.Alunos.Add(alunos);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(alunos);
        }

        // GET: Alunos/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alunos alunos = await db.Alunos.FindAsync(id);
            if (alunos == null)
            {
                return HttpNotFound();
            }
            return View(alunos);
        }

        // PUT: Alunos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Nome,Nascimento,Responsavel,Telefone,Endereco,Sexo,Graduacao,Status")] Alunos alunos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alunos).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(alunos);
        }

        // GET: Alunos/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alunos alunos = await db.Alunos.FindAsync(id);
            if (alunos == null)
            {
                return HttpNotFound();
            }
            return View(alunos);
        }

        // Delete: Alunos/Delete/5
        [HttpDelete, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Alunos alunos = await db.Alunos.FindAsync(id);
            db.Alunos.Remove(alunos);
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
