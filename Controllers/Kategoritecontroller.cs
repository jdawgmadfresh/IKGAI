using Main.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers
{
    public class Kategoritecontroller : Controller
    {
        // GET: Kategoritecontroller
        public ActionResult Index()
        {
           List<Kategorite> lista = new List<Kategorite>();
            return View(lista);
        }

        // GET: Kategoritecontroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kategoritecontroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kategoritecontroller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Kategoritecontroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kategoritecontroller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Kategoritecontroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kategoritecontroller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
