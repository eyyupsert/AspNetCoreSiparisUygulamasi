using Microsoft.AspNetCore.Mvc;
using SiparisOtomasyon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisOtomasyon.ViewComponents
{
    public class UrunList : ViewComponent
    {
        private readonly IUrunRepository _urunRepository;
        public UrunList(IUrunRepository urunRepository)
        {
            _urunRepository = urunRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_urunRepository.GetirHepsi());
        }
    }
}
