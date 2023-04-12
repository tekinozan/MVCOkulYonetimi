using MVCOkulYonetimi.Business.Repository.GenericRepositoryManager;
using MVCOkulYonetimi.Data.Models.Context;
using MVCOkulYonetimi.Data.Models.Entities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOkulYonetimi.Controllers
{
    public class OgretmenController : Controller
    {
        GenericRepository<Ogretmen> repo = new GenericRepository<Ogretmen>();
        OkulDbContext db = new OkulDbContext();
        // GET: Ogretmen
        public ActionResult Index(int sayfa = 1)
        {
            var ogretmenler = repo.HepsiniGetir().ToPagedList(sayfa, 5);
            return View(ogretmenler);
        }

        [HttpGet]
        public ActionResult Ekle()
        {

            return View("Ekle");
        }

        [HttpPost]
        public ActionResult Ekle(Ogretmen ogretmen)
        {
            repo.Ekle(ogretmen);
            return RedirectToAction("Index", "Ogretmen");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var ogretmen = db.Ogretmenler.Find(id);
            if (ogretmen == null)
            {
                return HttpNotFound();
            }
            return View("Guncelle", ogretmen);
        }

        [HttpPost]
        public ActionResult Guncelle(Ogretmen ogretmen)
        {
            repo.Guncelle(ogretmen);
            return RedirectToAction("Index", "Ogretmen");
        }


        [HttpGet]
        public ActionResult Sil(int id)
        {
            var ogretmen = db.Ogretmenler.Find(id);
            if (ogretmen == null)
            {
                return HttpNotFound();
            }
            repo.Sil(id);
            return RedirectToAction("Index", "Ogretmen");
        }
    }
}