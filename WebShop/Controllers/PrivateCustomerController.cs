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
    public class PrivateCustomerController : Controller
    {
        private WebShopDBContext db = new WebShopDBContext();

        // GET: PrivateCustomer
        public ActionResult Index()
        {
            return View(db.PrivateCustomers.ToList());//changed this from Customers to PrivateCustomers
        }

        // GET: PrivateCustomer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrivateCustomer privateCustomer = db.PrivateCustomers.Find(id);//changed from customers to privatecustomers
            if (privateCustomer == null)
            {
                return HttpNotFound();
            }
            return View(privateCustomer);
        }

        // GET: PrivateCustomer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrivateCustomer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,Firstname,Lastname,MailAdress,StreetAdress,City,ZipCode,MobileNumber")] PrivateCustomer privateCustomer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(privateCustomer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(privateCustomer);
        }

        // GET: PrivateCustomer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrivateCustomer privateCustomer = db.PrivateCustomers.Find(id);
            if (privateCustomer == null)
            {
                return HttpNotFound();
            }
            return View(privateCustomer);
        }

        // POST: PrivateCustomer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,Firstname,Lastname,MailAdress,StreetAdress,City,ZipCode,MobileNumber")] PrivateCustomer privateCustomer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(privateCustomer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(privateCustomer);
        }

        // GET: PrivateCustomer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrivateCustomer privateCustomer = db.PrivateCustomers.Find(id);
            if (privateCustomer == null)
            {
                return HttpNotFound();
            }
            return View(privateCustomer);
        }

        // POST: PrivateCustomer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PrivateCustomer privateCustomer = db.PrivateCustomers.Find(id);
            db.Customers.Remove(privateCustomer);
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
