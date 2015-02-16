using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{ 
    public class TaskController : Controller
    {
        private TaskContext db = new TaskContext();





        public ActionResult Index(string searchTerm = null)
        {
            if (searchTerm == null)
                return View(db.Tasks.ToList());
            else
            {
                var model = db.Tasks.Where(r => r.Title.StartsWith(searchTerm));
                return View(model);

            }
        }

   
        public ViewResult Details(int id)
        {
            Task task = db.Tasks.Find(id);
            return View(task);
        }

        //
        // GET: /Task/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Task/Create

        [HttpPost]
        public ActionResult Create(Task newTask)
        {
            try
            {
                using (var db = new TaskContext())
                {
                    db.Tasks.Add(newTask);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Task/Edit/5
 
        public ActionResult Edit(int id)
        {
            Task task = db.Tasks.Find(id);
            return View(task);
        }

        //
        // POST: /Task/Edit/5

        [HttpPost]
        public ActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                db.Entry(task).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(task);
        }

        //
        // GET: /Task/Delete/5
 
        public ActionResult Delete(int id)
        {
            Task task = db.Tasks.Find(id);
            return View(task);
        }

        //
        // POST: /Task/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Task task = db.Tasks.Find(id);
            db.Tasks.Remove(task);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    
public  string optionValue { get; set; }
public  string optionvalue { get; set; }}


}