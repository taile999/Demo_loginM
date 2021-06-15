using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Transactions;
using CAPDEMO.Models;
using System.Data.Entity;
namespace CAPDEMO.Controllers
{
    public class AdminController : Controller
    {
        CAP2021Entities DB = new CAP2021Entities();
        // GET: Admin
        public ActionResult Index()
        {
            var model = DB.SINHVIENs;

            return View(model.ToList());
        }
        public ActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(SINHVIEN model)
        {
            if (ModelState.IsValid)
            {
                using (var scope = new TransactionScope())
                {
                    DB.SINHVIENs.Add(model);
                    DB.SaveChanges();
                    scope.Complete();
                    return RedirectToAction("Index");
                    
                }
            }
            return View(model);
        }
        
        public ActionResult Edit (int id)
        {
            var model = DB.SINHVIENs.Find(id);
            if (model == null)
                return HttpNotFound();
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit (SINHVIEN model)
        {
            if (ModelState.IsValid)
            {
                DB.Entry(model).State = EntityState.Modified;
                DB.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var model = DB.SINHVIENs.Find(id);
            if (model == null)
                return HttpNotFound();
            DB.SINHVIENs.Remove(model);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ImportExcel()
        {
            return View();
        }
    }
}