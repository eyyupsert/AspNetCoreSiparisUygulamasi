using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisOtomasyon.Models
{
    public class UrunEkleModel
    {
        [Required(ErrorMessage ="Ad alanı gereklidir")]
        public string Ad { get; set; }
        [Range(0, (double)decimal.MaxValue, ErrorMessage = "Fiyat 0'dan büyük olmalıdır")]
        public decimal Fiyat { get; set; }
        public IFormFile Resim { get; set; }
    }
}
