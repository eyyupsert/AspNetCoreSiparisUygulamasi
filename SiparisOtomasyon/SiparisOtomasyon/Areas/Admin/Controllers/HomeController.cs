using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiparisOtomasyon.Models;
using SiparisOtomasyon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiparisOtomasyon.Entities;
using System.IO;

namespace SiparisOtomasyon.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUrunRepository _urunRepository;

        public HomeController(IUrunRepository urunRepository)
        {
            _urunRepository = urunRepository;
        }
        public IActionResult Index()
        {
            return View(_urunRepository.GetirHepsi());
        }
        public IActionResult Ekle()
        {
            return View(new UrunEkleModel());
        }
        [HttpPost]
        public IActionResult Ekle(UrunEkleModel model)
        {
            if (ModelState.IsValid)
            {
                Urun urun = new Urun();
                if (model.Resim != null)
                {
                    var uzanti = Path.GetExtension(model.Resim.FileName);
                    var yeniResimAd = Guid.NewGuid() + uzanti;
                    var yuklenecekYer = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot/img/" + yeniResimAd);
                    var stream = new FileStream(yuklenecekYer,FileMode.Create);
                    model.Resim.CopyTo(stream);
                    urun.Resim = yeniResimAd; 
                }
                
                urun.Ad = model.Ad;
                urun.Fiyat = model.Fiyat;
                _urunRepository.Ekle(urun);

                return RedirectToAction("Index","Home",new { area= "Admin" });
            }
            return View(model);
        }

    }
}
