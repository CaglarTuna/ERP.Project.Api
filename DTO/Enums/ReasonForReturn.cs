using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Enums
{
    public enum ReasonForReturn
    {
        [Display(Name ="Ürün İptali")]
        UrunIptali=1,
        [Display(Name ="Malzeme Kalite Eksikliği")]
        MalzemeKaliteEksikliği=2,
        [Display(Name ="Malzeme Bozuk")]
        MalzemeBozuk=3,
        [Display(Name ="Üretim Çıktısı")]
        UretimCıktısı=4,
        [Display(Name ="Diğer")]
        Diger=5
    }
}
