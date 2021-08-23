using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisOtomasyon.Interfaces
{
    public interface IGenericRepository<Tablo> where Tablo: class, new()
    {
        void Ekle(Tablo tablo);
        void Guncelle(Tablo tablo);
        void Sil(Tablo tablo);
        public List<Tablo> GetirHepsi();
        public Tablo GetirIdile(int id);
    }
}
