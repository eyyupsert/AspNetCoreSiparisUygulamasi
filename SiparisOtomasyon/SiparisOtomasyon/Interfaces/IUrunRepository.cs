using SiparisOtomasyon.Entities;
using SiparisOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisOtomasyon.Interfaces
{
    public interface IUrunRepository : IGenericRepository<Urun>
    {
        List<Kategori> GetirKategoriler(int urunId);
        void Ekle(UrunEkleModel model);
    }
}
