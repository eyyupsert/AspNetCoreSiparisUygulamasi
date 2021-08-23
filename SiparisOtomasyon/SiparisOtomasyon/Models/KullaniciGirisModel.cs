using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisOtomasyon.Models
{
    public class KullaniciGirisModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez")]
        public string KullaiciAd { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string Sifre { get; set; }
        public bool BeniHatirla { get; set; }
    }
}
