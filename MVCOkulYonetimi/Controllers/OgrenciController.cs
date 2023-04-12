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
    public class OgrenciController : Controller
    {
        GenericRepository<Ogrenci> repo = new GenericRepository<Ogrenci>();
        OkulDbContext db = new OkulDbContext();
        // GET: Ogrenci
        [HttpGet]
        public ActionResult Index(int sayfa = 1)
        {
            var ogrenciler = db.Ogrenciler.Include("Ogretmen").ToList().ToPagedList(sayfa, 4);
            return View(ogrenciler);
        }

        [HttpGet]
        public ActionResult Ekle()
        {

            return View("Ekle");
        }

        [HttpPost]
        public ActionResult Ekle(Ogrenci ogrenci)
        {
            repo.Ekle(ogrenci);
            return RedirectToAction("Index", "Ogrenci");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var ogrenci = db.Ogrenciler.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View("Guncelle", ogrenci);
        }

        [HttpPost]
        public ActionResult Guncelle(Ogrenci ogrenci)
        {
            repo.Guncelle(ogrenci);
            return RedirectToAction("Index", "Ogrenci");
        }


        [HttpGet]
        public ActionResult Sil(int id)
        {
            var calisan = db.Ogrenciler.Find(id);
            if (calisan == null)
            {
                return HttpNotFound();
            }
            repo.Sil(id);
            return RedirectToAction("Index", "Ogrenci");
        }

    }
}