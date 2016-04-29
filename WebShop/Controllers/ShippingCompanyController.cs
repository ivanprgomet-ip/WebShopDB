using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebShop.Data_Access_Layer;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ShippingCompanyController : Controller
    {
        private WebShopDBContext db = new WebShopDBContext();

        // GET: ShippingCompany
        public ActionResult Index()
        {
            return View(db.ShippingCompanies.ToList());
        }

        // GET: ShippingCompany/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingCompany shippingCompany = db.ShippingCompanies.Find(id);
            if (shippingCompany == null)
            {
                return HttpNotFound();
            }
            return View(shippingCompany);
        }

        // GET: ShippingCompany/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShippingCompany/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShippingCompanyID,ShippingCompanyName,ShippingCost")] ShippingCompany shippingCompany)
        {
            if (ModelState.IsValid)
            {
                db.ShippingCompanies.Add(shippingCompany);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shippingCompany);
        }

        // GET: ShippingCompany/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingCompany shippingCompany = db.ShippingCompanies.Find(id);
            if (shippingCompany == null)
            {
                return HttpNotFound();
            }
            return View(shippingCompany);
        }

        // POST: ShippingCompany/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShippingCompanyID,ShippingCompanyName,ShippingCost")] ShippingCompany shippingCompany)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shippingCompany).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shippingCompany);
        }

        // GET: ShippingCompany/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingCompany shippingCompany = db.ShippingCompanies.Find(id);
            if (shippingCompany == null)
            {
                return HttpNotFound();
            }
            return View(shippingCompany);
        }

        // POST: ShippingCompany/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShippingCompany shippingCompany = db.ShippingCompanies.Find(id);
            db.ShippingCompanies.Remove(shippingCompany);
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
