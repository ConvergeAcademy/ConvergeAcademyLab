using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class RegisterationController : Controller
    {
        //
        // GET: /Registeration/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Registeration/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Registeration/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Registeration/Create

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

        //
        // GET: /Registeration/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Registeration/Edit/5

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

        //
        // GET: /Registeration/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Registeration/Delete/5

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
