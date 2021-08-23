using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisOtomasyon.Entities
{
    [Dapper.Contrib.Extensions.Table("Uruns")]
    public class Urun
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Ad { get; set; }
        [MaxLength(250)]
        public string Resim { get; set; }
        public decimal Fiyat { get; set; }

        public List<UrunKategori> UrunKategoriler { get; set; }

    }
}
