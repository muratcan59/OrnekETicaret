using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ETicaret.Model
{
    public class Kategori:Base
    {

        public int? UstKategoriId { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Kategori ismi 2-25 karakter uzunluğunda olmalı.", MinimumLength = 2)]
        public string Ad { get; set; }

        //navigation properties
        [ForeignKey("UstKategoriId")]
        [XmlIgnore]
        public virtual Kategori UstKategorisi { get; set; }
    }
}