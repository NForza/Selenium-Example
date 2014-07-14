using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class RequestInfoController : Controller
    {
        // GET: SendInfo
        public ActionResult Index()
        {
            return View();
        }

        // GET: SendInfo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SendInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SendInfo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SendInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SendInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SendInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SendInfo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
