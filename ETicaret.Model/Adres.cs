using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETicaret.Model
{
    public class Adres:Base
    {

        [Required]
        [StringLength(100, ErrorMessage = "Ad 4-100 karakter uzunlugunda olmalıdır.", MinimumLength = 4)]
        public string Icerik { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Ad 2-25 karakter uzunlugunda olmalıdır.", MinimumLength = 2)]
        public string Baslik { get; set; }

    }

}