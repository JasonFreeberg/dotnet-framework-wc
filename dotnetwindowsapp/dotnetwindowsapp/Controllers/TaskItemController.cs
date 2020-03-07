﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dotnetwindowsapp.Models;

namespace dotnetwindowsapp.Controllers
{
    
    public class TaskItemController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: TaskItem
        public ActionResult Index()
        {
            return View(db.Tasks.ToList());
        }

        // GET: TaskItem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskItem taskItem = db.Tasks.Find(id);
            if (taskItem == null)
            {
                return HttpNotFound();
            }
            return View(taskItem);
        }

        // GET: TaskItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskItem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,Description")] TaskItem taskItem)
        {
            if (ModelState.IsValid)
            {
                db.Tasks.Add(taskItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taskItem);
        }

        // GET: TaskItem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskItem taskItem = db.Tasks.Find(id);
            if (taskItem == null)
            {
                return HttpNotFound();
            }
            return View(taskItem);
        }

        // POST: TaskItem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Title,Description")] TaskItem taskItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taskItem);
        }

        // GET: TaskItem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskItem taskItem = db.Tasks.Find(id);
            if (taskItem == null)
            {
                return HttpNotFound();
            }
            return View(taskItem);
        }

        // POST: TaskItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaskItem taskItem = db.Tasks.Find(id);
            db.Tasks.Remove(taskItem);
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
