using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETicaret.Model
{
    public class UrunYorum:Base
    {
        [ForeignKey("Urunu")]
        public int UrunId { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Ad 2-25 karakter uzunluğunda olmalı.", MinimumLength = 2)]
        public string Baslik { get; set; }
        [Required]
        public string Icerik { get; set; }

        //navigation properties
        public virtual Urun Urunu { get; set; }

    }
}