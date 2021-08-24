using SiparisOtomasyon.Contexts;
using SiparisOtomasyon.Entities;
using SiparisOtomasyon.Interfaces;
using SiparisOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisOtomasyon.Repositories
{
    public class UrunRepository : GenericRepository<Urun>, IUrunRepository
    {
        public void Ekle(UrunEkleModel model)
        {
            throw new NotImplementedException();
        }

        public List<Kategori> GetirKategoriler(int urunId)
        {
            using var context = new CoreDersContext();
            return context.Uruns.Join(context.UrunKategories, urun => urun.Id, urunKategoriler =>
            urunKategoriler.UrunId, (u, uc) => new
                {
                    urun = u,
                    urunKategori=uc,

                }).Join(context.Kategoris,iki=>iki.urunKategori.KategoriId,kategori=>kategori.Id,
                (uc,k)=>new { 
                    urun=uc.urun,
                    kategori=k,
                    urunKategori=uc.urunKategori
                }).Where(I=>I.urun.Id==urunId).Select(I=>new Kategori { 

                Ad=I.kategori.Ad,
                Id=I.kategori.Id,

                }).ToList();
            
        }
    }
}
