using System;
using System.Collections.Generic;
using System.Data.Metadata.Edm;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemperatureReporter.Contracts.Input;
using TemperatureReporter.Implementation.Input;

namespace TemperatureReporter.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private IInputTemperatureFileReader fileReader;

        public HomeController()
        {
            this.fileReader = new InputTemperatureFileReader();
        }
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload()
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];

                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Input/"), fileName);
                    file.SaveAs(path);
                    var logs = fileReader.ReadTyreTemperatures(path);
                }
            }

            return RedirectToAction("Results");
        }

        public ActionResult Results()
        {
            return View();
        }

        //
        // POST: /Home/Create

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


        public ActionResult GetData()
        {
            var data = new[] { new Entry() { value = 20, xaxis= 2008 }, new Entry() { value = 10, xaxis= 2009 } };

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public class Entry
        {
            public int xaxis { get; set; }
            public int value { get; set; }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

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
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

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
