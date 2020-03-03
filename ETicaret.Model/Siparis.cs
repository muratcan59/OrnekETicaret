using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETicaret.Model
{
    public class Siparis:Base
    {
            [Required]
            [ForeignKey("Adresi")]
        public int AdresId { get; set; }
            [Required]
            [ForeignKey("Sepeti")]
            public int SepetId { get; set; }
            public string Tutar { get; set; }
            [Required]
            public DateTime TeslimTarihi { get; set; }

        //navigation properties
        public virtual Sepet Sepeti { get; set; }
        public virtual Adres Adresi { get; set; }

    }
}