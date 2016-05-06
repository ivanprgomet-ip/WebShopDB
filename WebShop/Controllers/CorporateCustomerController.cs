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
    public class CorporateCustomerController : Controller
    {
        private WebShopDBContext db = new WebShopDBContext();

        // GET: CorporateCustomer
        public ActionResult Index()
        {
            return View(db.CorporateCustomers.ToList());
        }

        // GET: CorporateCustomer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CorporateCustomer corporateCustomer = db.CorporateCustomers.Find(id);
            if (corporateCustomer == null)
            {
                return HttpNotFound();
            }
            return View(corporateCustomer);
        }

        // GET: CorporateCustomer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CorporateCustomer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,Firstname,Lastname,MailAdress,StreetAdress,City,ZipCode,CompanyName,CompanyPhoneNumber,CompanyWebSite")] CorporateCustomer corporateCustomer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(corporateCustomer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(corporateCustomer);
        }

        // GET: CorporateCustomer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CorporateCustomer corporateCustomer = db.CorporateCustomers.Find(id);
            if (corporateCustomer == null)
            {
                return HttpNotFound();
            }
            return View(corporateCustomer);
        }

        // POST: CorporateCustomer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,Firstname,Lastname,MailAdress,StreetAdress,City,ZipCode,CompanyName,CompanyPhoneNumber,CompanyWebSite")] CorporateCustomer corporateCustomer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(corporateCustomer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(corporateCustomer);
        }

        // GET: CorporateCustomer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CorporateCustomer corporateCustomer = db.CorporateCustomers.Find(id);
            if (corporateCustomer == null)
            {
                return HttpNotFound();
            }
            return View(corporateCustomer);
        }

        // POST: CorporateCustomer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CorporateCustomer corporateCustomer = db.CorporateCustomers.Find(id);
            db.Customers.Remove(corporateCustomer);
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
