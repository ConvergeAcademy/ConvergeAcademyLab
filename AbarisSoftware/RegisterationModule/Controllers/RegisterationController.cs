using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegisterationModule.Models;
using RegisterationModule.DAL;

namespace RegisterationModule.Controllers
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
                User user = new User();
                user.EmailD = collection["EmailD"].ToString();
                user.FullName = collection["FullName"].ToString();
                user.Password = collection["Password"].ToString();

                //Calling DAL

                UserDAL userDAL = new UserDAL();
                userDAL.Registeration(user);


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
