using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SiparisOtomasyon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.TagHelpers
{
    [HtmlTargetElement("getirKategoriAd")]
    public class KategoriAd : TagHelper
    {
        private readonly IUrunRepository _urunRepository;
        public KategoriAd(IUrunRepository urunRepository)
        {
            _urunRepository = urunRepository;
        }
        public int UrunId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //TagBuilder builder = new TagBuilder("ul");
            //StringBuilder builder2 = new StringBuilder();
            //builder2.Append();
            string data = "";
            var gelenKAtegoriler = _urunRepository.GetirKategoriler(UrunId).Select(I => I.Ad);
            base.Process(context, output);
            foreach (var item in gelenKAtegoriler)
            {
                data += item+" ";
            }

            output.Content.SetContent(data);
        }
    }
}
