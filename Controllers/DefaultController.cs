using Deneme.Models;
using Microsoft.AspNetCore.Mvc;

namespace Deneme.Controllers {
    public class DefaultController : Controller {
        void mesajlar () {
            ViewBag.m1 = "Merhaba Dünya";
            }
        string mesajlar2 () {
            string cumle = "cumle girdili Merhaba Dünya";
            return cumle;
            }

        public IActionResult Index () {
            mesajlar ();
            return View ();
            }
        public IActionResult Urunler () {

            return View ();
            }
        public IActionResult Musteriler () {
            ViewBag.d = mesajlar2 ();
            return View ();
            }
        public IActionResult Sehirler () {
            Sehirler sehirler = new Sehirler ();
            sehirler.Id = 1;
            sehirler.Ad = "Ankara";
            sehirler.Nufus = 6000000;

            ViewBag.v2 = sehirler.Ad;
            ViewBag.v1 = sehirler.Id;
            ViewBag.v3 = sehirler.Nufus;

            return View ();
            }

        }
    }
