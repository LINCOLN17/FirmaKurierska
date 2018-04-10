using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirmaKurierska.Models;

namespace FirmaKurierska.Controllers
{
    public class CouriersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Couriers
        public async Task<ActionResult> Index()
        {
            var couriers = db.Couriers.Include(c => c.Car);
            return View(await couriers.ToListAsync());
        }

        // GET: Couriers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courier courier = await db.Couriers.FindAsync(id);
            if (courier == null)
            {
                return HttpNotFound();
            }
            return View(courier);
        }

        // GET: Couriers/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Cars, "ID", "ID");
            return View();
        }

        // POST: Couriers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,FirstName,LastName")] Courier courier)
        {
            if (ModelState.IsValid)
            {
                db.Couriers.Add(courier);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.Cars, "ID", "ID", courier.ID);
            return View(courier);
        }

        // GET: Couriers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courier courier = await db.Couriers.FindAsync(id);
            if (courier == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.Cars, "ID", "ID", courier.ID);
            return View(courier);
        }

        // POST: Couriers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,FirstName,LastName")] Courier courier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courier).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.Cars, "ID", "ID", courier.ID);
            return View(courier);
        }

        // GET: Couriers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courier courier = await db.Couriers.FindAsync(id);
            if (courier == null)
            {
                return HttpNotFound();
            }
            return View(courier);
        }

        // POST: Couriers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Courier courier = await db.Couriers.FindAsync(id);
            db.Couriers.Remove(courier);
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
