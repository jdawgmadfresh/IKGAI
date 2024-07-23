using Main.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Main.Controllers
{
    public class ProduktetController : Controller
    {
        private DB _db;
        public ProduktetController(DB db)
        {
            _db=db;
        }
        // GET: ProduktetController
        public ActionResult Index()
        {

            List<Produktet> lista = new List<Produktet>();
            lista = _db.Produktet.ToList();
            return View(lista);
        }

        // GET: ProduktetController/Details/5
        public ActionResult Details(int id)
        {
            Produktet p1 = new Produktet()
            {
                Emri = "Produkti " + id,
                Numri = id
            };
            return View(p1);
        }

        // GET: ProduktetController/Create
        public ActionResult Create()
        {
            var kategorite = _db.Produktet.ToList();
            var kat_sel_list = new SelectList(kategorite, "Numri", "Emri");
            ViewData["kategorite"] = kat_sel_list;
            return View();
        }

        // POST: ProduktetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produktet NewProdukt)
        {
            _db.Produktet.Add(NewProdukt);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ProduktetController/Edit/5
        public ActionResult Edit(int id)
        {
            var ProduktiNeModifikim = _db.Produktet.Find(id);
            Produktet newProdukt = new Produktet();
            foreach (var item in _db.Produktet)
            {
                if (item.Numri == id)
                    newProdukt = item;
            }
            return View(ProduktiNeModifikim);
            return RedirectToAction("Index");
        }

        // POST: ProduktetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Produktet produktiNewData)
        {

            var ProduktiExisting = _db.Produktet.Find(produktiNewData.Numri);
            if (ProduktiExisting != null)
            {
                ProduktiExisting.Emri = produktiNewData.Emri;
                _db.SaveChanges();
            }
            else
            {
                return View();
            }
            return RedirectToAction(nameof(Index));

        }

        // GET: ProduktetController/Delete/5
        public ActionResult Delete(int id)
        {
            var comment = _db.Produktet.Find(id);
            return View(comment);
        }

        // POST: ProduktetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var comment = _db.Produktet.Find(id);
                if (comment != null)
                {
                    _db.Produktet.Remove(comment);
                    _db.SaveChanges();

                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
            }
            return View();
        }
    }
}
